﻿using SanAndreasUnity.Importing.Conversion;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

namespace SanAndreasUnity.Behaviours
{
    public class MiniMap : MonoBehaviour
    {
        private const int tileEdge = 12; // width/height of map in tiles
        private const int tileCount = tileEdge * tileEdge; // number of tiles
        private const int mapEdge = 6000; // width/height of map in world coordinates
        private const int texSize = 128; // width/height of single tile in px
        private const int mapSize = tileEdge * texSize; // width/height of whole map in px
        private const int uiSize = 256, uiOffset = 10;
        private const bool outputChunks = false, outputImage = true;

        private TextureDictionary huds;

        private Texture2D northBlip, playerBlip, mapTexture;
        private Sprite mapSprite, circleMask;
        private bool enableMinimap, isReady, isSetup;

        public Canvas outlineCanvas,
                      iconCanvas,
                      canvas;

        public Image northImage, playerImage, outlineImage, mapImage;

        public RectTransform mapTransform, maskTransform;

        public float zoom = 1.3f;

        public const float maxVelocity = 300f;
        public static float[] zooms = new float[7] { .75f, .875f, 1f, 1.15f, 1.3f, 1.5f, 1.8f };

        [HideInInspector]
        public int zoomSelector = 4;

        public float zoomDuration = 1;

        private Transform northPivot;

        //Zoom vars
        private bool startZooming;

        private float startTimeZooming;

        public static void AssingMinimap()
        {
            GameObject UI = GameObject.FindGameObjectWithTag("UI");
            Transform root = UI != null ? UI.transform : null;

            GameObject minimap = GameObject.FindGameObjectWithTag("Minimap");
            if (minimap == null)
            {
                minimap = new GameObject();

                minimap.name = "Minimap";
                minimap.tag = "Minimap";

                minimap.transform.parent = root;
            }

            MiniMap map = minimap.GetComponent<MiniMap>();

            if (map == null)
                map = minimap.AddComponent<MiniMap>();

            map.isReady = true;
            if (!map.isSetup) map.Setup();
        }

        private void loadTextures()
        {
            mapTexture = new Texture2D(mapSize, mapSize, TextureFormat.ARGB32, false, true);
            mapTexture.wrapMode = TextureWrapMode.Repeat;
            mapTexture.filterMode = FilterMode.Point;

            string folder = Path.Combine(Application.streamingAssetsPath, "map-chunks");

            if (outputChunks)
            {
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
            }

            Debug.Log("Merging all map sprites into one sprite.");
            for (int i = 0; i < tileCount; i++)
            {
                // Offset
                int y = ((i / tileEdge) + 1) * texSize,
                    x = (i % tileEdge) * texSize;

                string name = "radar" + ((i < 10) ? "0" : "") + i;
                var texDict = TextureDictionary.Load(name);

                Texture2D tex = texDict.GetDiffuse(name).Texture;

                if (outputChunks)
                {
                    string id = name.Substring(5);
                    Texture2D image = new Texture2D(texSize, texSize, TextureFormat.ARGB32, false);

                    for (int xx = 0; xx < texSize; ++xx)
                        for (int yy = 0; yy < texSize; ++yy)
                            image.SetPixel(xx, texSize - yy - 1, tex.GetPixel(xx, yy));

                    image.Apply();

                    File.WriteAllBytes(Path.Combine(folder, string.Format("{0}.jpg", id)), ImageConversion.EncodeToPNG(image));
                }

                for (int ii = 0; ii < texSize; ++ii)
                    for (int jj = 0; jj < texSize; ++jj)
                        mapTexture.SetPixel(x + ii, texSize - (y + jj) - 1, tex.GetPixel(ii, jj));
            }

            mapTexture.Apply();
            mapSprite = Sprite.Create(mapTexture, new Rect(0, 0, mapTexture.width, mapTexture.height), new Vector2(mapTexture.width, mapTexture.height) / 2);

            if (outputImage)
                File.WriteAllBytes(Path.Combine(Application.streamingAssetsPath, "gta-map.png"), mapTexture.EncodeToPNG());

            circleMask = Resources.Load<Sprite>("Sprites/MapCircle");

            huds = TextureDictionary.Load("hud");
            northBlip = huds.GetDiffuse("radar_north").Texture;
            playerBlip = huds.GetDiffuse("radar_centre").Texture;

            northImage.sprite = Sprite.Create(northBlip, new Rect(0, 0, northBlip.width, northBlip.height), new Vector2(northBlip.width, northBlip.height) / 2);
            playerImage.sprite = Sprite.Create(playerBlip, new Rect(0, 0, playerBlip.width, playerBlip.height), new Vector2(playerBlip.width, playerBlip.height) / 2);
        }

        // --------------------------------

        #region Private fields

        private Player player;
        private PlayerController playerController;
        private float lastZoom;

        #endregion Private fields

        private void Setup()
        {
            loadTextures();

            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            player = playerObj.GetComponent<Player>();
            playerController = playerObj.GetComponent<PlayerController>();

            mapImage.sprite = mapSprite;

            canvas.enabled = false;

            Debug.Log("Canvas disabled!");

            GetComponent<RectTransform>().sizeDelta = new Vector2(uiSize, uiSize);

            isSetup = true;
        }

        private void Awake()
        {
            if (!isReady)
                return;

            Setup();
        }

        private void Update()
        {
            if (!isReady) return;

            if (!enableMinimap)
            {
                canvas.enabled = true;
                iconCanvas.enabled = true;
                outlineCanvas.enabled = true;
                enableMinimap = true;

                // Must review: For some reason values are Y-axis inverted

                float left = Screen.width - uiSize - uiOffset,
                      top = Screen.height - uiSize - uiOffset * 2;

                Vector3 globalPos = new Vector3(left, top, 0) / 2;

                maskTransform.localPosition = globalPos;

                playerImage.rectTransform.localPosition = globalPos;
                playerImage.rectTransform.localScale = Vector3.one * .2f;
                playerImage.rectTransform.localRotation = Quaternion.Euler(0, 0, 180);

                northPivot = northImage.rectTransform.parent;

                northPivot.localPosition = globalPos;
                northPivot.localScale = Vector3.one * .2f;

                northImage.rectTransform.localPosition = new Vector3(0, uiSize / 2, 0) / .2f;
                northImage.rectTransform.localRotation = Quaternion.Euler(0, 180, 0);

                outlineImage.rectTransform.localPosition = globalPos;
                outlineImage.rectTransform.sizeDelta = Vector2.one * uiSize;
                outlineImage.rectTransform.localScale = Vector3.one * 1.05f;
            }

            if (Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.B))
                startZooming = true;

            if (Input.GetKeyDown(KeyCode.N))
            {
                ++zoomSelector;
                ChangeZoom();
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                --zoomSelector;
                ChangeZoom();
            }
        }

        private void FixedUpdate()
        {
            if (mapTransform != null)
            {
                float deltaZoom = zoom - lastZoom;

                mapTransform.localScale = new Vector3(zoom, zoom, 1);

                lastZoom = zoom;
            }

            zoom = Mathf.Lerp(.9f, 1.3f, 1 - Mathf.Clamp(playerController.CurVelocity, 0, maxVelocity) / maxVelocity);
        }

        private void LateUpdate()
        {
            if (!isReady) return;
            //if (!playerController.CursorLocked) return; // Note: This must be activated when on debug

            Vector3 pPos = player.transform.position, defPos = (new Vector3(pPos.x, pPos.z, 0) / (-1000f / uiSize));
            mapTransform.localPosition = new Vector3(defPos.x * zoom, defPos.y * zoom, 1); // Why?

            float relAngle = Camera.main.transform.eulerAngles.y;
            maskTransform.localRotation = Quaternion.Euler(0, 0, relAngle);
            northPivot.localRotation = Quaternion.Euler(0, 0, relAngle);

            playerImage.rectTransform.localRotation = Quaternion.Euler(0, 0, relAngle - (player.transform.eulerAngles.y + 180));
        }

        private void ChangeZoom()
        {
            if (startZooming)
            {
                startTimeZooming = Time.time;
                startZooming = false;
            }

            zoomSelector = GetClampedZoomSelector(zoomSelector);
            float curZoom = zooms[zoomSelector % zooms.Length],
                  lastZoom = zooms[GetClampedZoomSelector(zoomSelector - 1) % zooms.Length];

            zoom = Mathf.Lerp(lastZoom, curZoom, (Time.time - startTimeZooming) / zoomDuration);
        }

        private int GetClampedZoomSelector(int? val = null)
        {
            int zoomVal = val == null ? zoomSelector : val.Value;

            if (zoomVal < 0)
                zoomVal = zooms.Length - 1;

            return zoomVal;
        }
    }
}