using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class ARModelPlacement : MonoBehaviour
{
    private ARRaycastManager raycastManager;  // To handle plane detection
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();  // To store raycast hit results

    [SerializeField] private GameObject modelPrefab;  // The 3D model (planet) to place

    private GameObject placedModel;  // To keep a reference to the placed model
    private bool modelPlaced = false;  // To ensure we only place the model once

    void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        // Check if the model has already been placed; if so, do nothing
        if (modelPlaced)
            return;

        // Check if the user has touched the screen
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Only proceed if the touch is a tap (not a swipe or drag)
            if (touch.phase == TouchPhase.Began)
            {
                // Perform a raycast to check if a detected plane is hit
                if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
                {
                    // Get the first hit result (closest plane)
                    Pose hitPose = hits[0].pose;

                    // Instantiate the model at the hit position and rotation
                    placedModel = Instantiate(modelPrefab, hitPose.position, hitPose.rotation);

                    // Optionally: Anchor the model to the plane to keep it stable
                    placedModel.AddComponent<ARAnchor>();

                    // Mark the model as placed so we don't place it again
                    modelPlaced = true;
                }
            }
        }
    }
}
