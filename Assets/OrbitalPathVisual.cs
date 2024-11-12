using UnityEngine;

public class OrbitalPath : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int segments = 100;  // Number of segments for a smooth circle
    public float radius = 5f;   // Radius of the orbit

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = segments + 1;
        lineRenderer.useWorldSpace = true;
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;

        DrawOrbit();
    }

    void DrawOrbit()
    {
        float angle = 0f;
        for (int i = 0; i <= segments; i++)
        {
            float x = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;
            float z = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
            lineRenderer.SetPosition(i, new Vector3(x, 0, z)); // Y = 0 for a flat orbit
            angle += (360f / segments);
        }
    }
}