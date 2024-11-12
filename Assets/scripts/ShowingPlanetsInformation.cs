using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowingPlanetsInformation : MonoBehaviour
{
    [SerializeField]
    public GameObject messageBox;

    private void OnMouseDown()
    {
        Debug.Log("Click");
        Instantiate(messageBox, transform.position, Quaternion.identity);
    }
}
