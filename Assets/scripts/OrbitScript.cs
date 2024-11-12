using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour
{

    public LineRenderer myLineRenderer;

    public int subdivisions = 10;

    public float radius = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angleStep = 2f * Mathf.PI / subdivisions;

        myLineRenderer.positionCount = subdivisions;

        for (int i = 0; i < subdivisions; i++)
        {
            float xPosition = radius * Mathf.Cos(angleStep * i);
            float zPosition = radius * Mathf.Sin(angleStep * i);

            Vector3 pointInCircle = new Vector3(xPosition, 0f, zPosition);

            myLineRenderer.SetPosition(i, pointInCircle);
        }

    }
}
