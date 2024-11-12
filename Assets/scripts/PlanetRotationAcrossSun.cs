using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    [SerializeField] public Transform sun;        // Reference to the Sun (central point)
    [SerializeField] public float orbitSpeed = 10f;  // Speed of the orbit
    [SerializeField] public float orbitRadius = 20f; // Distance between the planet and the Sun

    private Vector3 orbitAxis;   // Axis to orbit around

    void Start()
    {
        if (sun == null)
        {
            Debug.LogError("Sun (central point) is not assigned.");
            return;
        }

        // Initialize orbit axis (assuming rotation around the Y axis)
        orbitAxis = Vector3.up;

        // Set initial position of the planet in relation to the Sun
        transform.position = sun.position + new Vector3(orbitRadius, 0, 0);
    }

    void Update()
    {
        // Perform orbit by rotating the planet around the Sun at a fixed distance
        transform.RotateAround(sun.position, orbitAxis, orbitSpeed * Time.deltaTime);
    }
}
