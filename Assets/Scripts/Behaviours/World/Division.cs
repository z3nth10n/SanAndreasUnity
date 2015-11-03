﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SanAndreasUnity.Behaviours.World
{
    public class Division : MonoBehaviour, IEnumerable<Division>, IComparable<Division>
    {
        private static readonly Comparison<MapObject> _sHorzSort =
            (a, b) => Math.Sign(a.CellPos.x - b.CellPos.x);

        private static readonly Comparison<MapObject> _sVertSort =
            (a, b) => Math.Sign(a.CellPos.y - b.CellPos.y);

        public static Division Create(Transform parent)
        {
            var obj = new GameObject();
            var split = obj.AddComponent<Division>();

            obj.transform.SetParent(parent);

            return split;
        }

        private const int LeafObjectLimit = 127;

        private Division _childA;
        private Division _childB;

        private List<MapObject> _objects;

        private bool _isVertSplit;
        private float _splitVal;

        private Vector3 _lastRefreshPos = new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);

        public Vector2 Min { get; private set; }
        public Vector2 Max { get; private set; }

        public bool IsSubdivided { get { return _objects == null; } }

        internal float LoadOrder { get; private set; }

        private float _nextGlobalLoadTime;

        public void SetBounds(Vector2 min, Vector2 max)
        {
            Min = min;
            Max = max;

            var mid = (Max + Min) * .5f;

            if (float.IsNaN(mid.x) || float.IsInfinity(mid.x))
            {
                mid.x = 0f;
            }

            if (float.IsNaN(mid.y) || float.IsInfinity(mid.y))
            {
                mid.y = 0f;
            }

            transform.position = new Vector3(mid.x, 0f, mid.y);

            name = String.Format("Split {0}, {1}", min, max);

            _objects = _objects ?? new List<MapObject>();
        }

        private void Subdivide()
        {
            if (IsSubdivided)
            {
                throw new InvalidOperationException("Already subdivided");
            }

            if (_objects.Count == 0)
            {
                throw new InvalidOperationException("Cannot subdivide an empty leaf");
            }

            var min = Max;
            var max = Min;

            foreach (var obj in _objects)
            {
                var pos = obj.CellPos;
                min.x = Mathf.Min(pos.x, min.x);
                min.y = Mathf.Min(pos.y, min.y);
                max.x = Mathf.Max(pos.x, max.x);
                max.y = Mathf.Max(pos.y, max.y);
            }

            _isVertSplit = max.x - min.x >= max.y - min.y;

            _objects.Sort(_isVertSplit ? _sHorzSort : _sVertSort);

            _childA = Create(transform);
            _childB = Create(transform);

            var mid = _objects.Count / 2;
            var median = (_objects[mid - 1].CellPos + _objects[mid].CellPos) * .5f;

            if (_isVertSplit)
            {
                _splitVal = median.x;
                _childA.SetBounds(Min, new Vector2(_splitVal, Max.y));
                _childB.SetBounds(new Vector2(_splitVal, Min.y), Max);
            }
            else
            {
                _splitVal = median.y;
                _childA.SetBounds(Min, new Vector2(Max.x, _splitVal));
                _childB.SetBounds(new Vector2(Min.x, _splitVal), Max);
            }

            _childA._objects = _objects;
            _childB._objects = new List<MapObject>();

            _childB._objects.AddRange(_childA._objects.Skip(mid));
            _childA._objects.RemoveRange(mid, _objects.Count - mid);

            _objects = null;
        }

        private void AddInternal(MapObject obj)
        {
            if (IsSubdivided)
            {
                var comp = _isVertSplit ? obj.CellPos.x : obj.CellPos.y;
                (comp < _splitVal ? _childA : _childB).AddInternal(obj);
                return;
            }

            _objects.Add(obj);

            if (_objects.Count > LeafObjectLimit) Subdivide();
        }

        public void Add(MapObject obj)
        {
            AddInternal(obj);
            UpdateParents();
        }

        public void AddRange(IEnumerable<MapObject> objs)
        {
            foreach (var obj in objs.OrderBy(x => x.RandomInt))
            {
                AddInternal(obj);
            }

            UpdateParents();
        }

        private void UpdateParents()
        {
            if (IsSubdivided)
            {
                _childA.UpdateParents();
                _childB.UpdateParents();
            }
            else
            {
                if (_objects.Count == 0) return;

                var sum = _objects.Aggregate(new Vector2(), (s, x) => s + x.CellPos);
                transform.position = new Vector3(sum.x / _objects.Count, 0f, sum.y / _objects.Count);

                foreach (var obj in _objects)
                {
                    obj.transform.SetParent(transform, true);
                }
            }
        }

        public bool Contains(MapObject obj)
        {
            return Contains(obj.CellPos);
        }

        public bool Contains(Vector3 pos)
        {
            return pos.x >= Min.x && pos.z >= Min.y && pos.x < Max.x && pos.z < Max.y;
        }

        public bool Contains(Vector2 pos)
        {
            return pos.x >= Min.x && pos.y >= Min.y && pos.x < Max.x && pos.y < Max.y;
        }

        private void OnDrawGizmosSelected()
        {
            if (!IsSubdivided) return;

            Gizmos.color = Color.green;

            var min = new Vector2(Math.Max(Min.x, -8192f), Math.Max(Min.y, -8192f));
            var max = new Vector2(Math.Min(Max.x, +8192f), Math.Min(Max.y, +8192f));

            if (_isVertSplit)
            {
                Gizmos.DrawLine(new Vector3(_splitVal, 0f, min.y), new Vector3(_splitVal, 0f, max.y));
            }
            else
            {
                Gizmos.DrawLine(new Vector3(min.x, 0f, _splitVal), new Vector3(max.x, 0f, _splitVal));
            }
        }

        public float GetDistance(Vector3 pos)
        {
            if (Contains(pos)) return 0f;

            var dx = Mathf.Max(Min.x - pos.x, pos.x - Max.x);
            var dz = Mathf.Max(Min.y - pos.z, pos.z - Max.y);

            return new Vector2(dx, dz).magnitude;
        }

        public bool RefreshLoadOrder(Vector3 from)
        {
            var toLoad = false;

            if (Vector3.Distance(from, _lastRefreshPos) > GetDistance(from) / 16f)
            {
                _lastRefreshPos = from;

                for (var i = _objects.Count - 1; i >= 0; --i)
                {
                    toLoad |= _objects[i].RefreshLoadOrder(from);
                }
            }
            else if (Time.time >= _nextGlobalLoadTime)
            {
                _nextGlobalLoadTime += UnityEngine.Random.value + 0.5f;

                for (var i = _objects.Count - 1; i >= 0; --i)
                {
                    if (float.IsPositiveInfinity(_objects[i].LoadOrder)) continue;

                    toLoad = true;
                    break;
                }
            }

            if (toLoad)
            {
                _objects.Sort();
                LoadOrder = _objects[0].LoadOrder;
            }
            else
            {
                LoadOrder = float.PositiveInfinity;
            }

            return toLoad;
        }

        public bool LoadWhile(Func<bool> predicate)
        {
            foreach (var toLoad in _objects)
            {
                if (float.IsPositiveInfinity(toLoad.LoadOrder)) break;
                toLoad.Show();
                if (!predicate()) break;
            }

            return predicate();
        }

        public IEnumerator<Division> GetEnumerator()
        {
            if (IsSubdivided)
            {
                return _childA.Concat(_childB).GetEnumerator();
            }

            return new[] { this }.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(Division other)
        {
            return LoadOrder > other.LoadOrder ? 1 : LoadOrder == other.LoadOrder ? 0 : -1;
        }
    }
}
