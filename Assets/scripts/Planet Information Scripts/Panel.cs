using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI panelTitle;

    [SerializeField]
    private TextMeshProUGUI panelInfo;

    private Dictionary<string, string> solarSystemDescriptions = new Dictionary<string, string>();

    void Start()
    {

        solarSystemDescriptions.Add("Sun", "The star at the center of our solar system, providing light and heat to all the planets.");
        solarSystemDescriptions.Add("Mercury", "The closest planet to the Sun, known for its extreme temperature fluctuations and barren surface.");
        solarSystemDescriptions.Add("Venus", "The second planet from the Sun, often called Earth's twin due to its similar size but has a toxic atmosphere.");
        solarSystemDescriptions.Add("Earth", "The third planet from the Sun, known for its water, atmosphere, and diverse life forms.");
        solarSystemDescriptions.Add("Mars", "The fourth planet from the Sun, known for its red surface, volcanoes, and evidence of past water.");
        solarSystemDescriptions.Add("Jupiter", "The largest planet in the Solar System, known for its Great Red Spot and many moons.");
        solarSystemDescriptions.Add("Saturn", "The sixth planet from the Sun, famous for its stunning rings made of ice and rock.");
        solarSystemDescriptions.Add("Uranus", "The seventh planet from the Sun, known for its unique sideways rotation and blue-green color.");
        solarSystemDescriptions.Add("Neptune", "The eighth planet from the Sun, known for its deep blue color and strong winds.");
        solarSystemDescriptions.Add("Pluto", "Once considered the ninth planet, now classified as a dwarf planet, located in the outer reaches of the solar system.");
    }

    void Update()
    {


        // If the user clicks the left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // If the hit object is tagged as "Planet"
                if (hit.collider.CompareTag("Planet"))
                {
                    panelTitle.text = hit.collider.gameObject.name;
                    panelInfo.text = solarSystemDescriptions[$"{hit.collider.gameObject.name}"];
                }
            }
        }
    }

}
