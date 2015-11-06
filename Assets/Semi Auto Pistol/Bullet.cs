using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static void Fire(GameObject prefab, Transform source, float cone)
    {
        var angle = Random.value*Mathf.PI;
        var error = (Random.value*2f - 1f)*cone;

        var xadd = Mathf.Cos(angle)*error;
        var yadd = Mathf.Sin(angle)*error;

        var dir = source.forward + source.right * xadd + source.up*yadd;
        var ray = new Ray(source.position, dir);

        var dist = 250f;

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, dist, -1 ^ LayerMask.GetMask("Vehicle"))) dist = Mathf.Min(dist, hit.distance);

        var inst = Instantiate(prefab);

        inst.transform.position = source.position;
        inst.GetComponent<Bullet>().Initialize(ray.GetPoint(dist));
    }

    private float _width;
    private Color _color;

    public LineRenderer LineRenderer;

    public void Initialize(Vector3 hitPos)
    {
        LineRenderer.useWorldSpace = true;
        LineRenderer.SetVertexCount(2);
        LineRenderer.SetPosition(0, transform.position);
        LineRenderer.SetPosition(1, hitPos);

        _width = .5f;
        _color = Color.white;

        LineRenderer.SetWidth(_width, _width);
        LineRenderer.SetColors(_color, _color);
    }

    void Update()
    {
        _color = new Color(1f, 1f, 1f, _color.a * 0.95f);

        LineRenderer.SetColors(_color, _color);

        if (_color.a < 1f/256f) Destroy(gameObject);
    }
}
