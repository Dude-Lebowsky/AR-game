using UnityEngine;

public class SpeedController : MonoBehaviour
{
    // Set the game speed to 1x speed
    public void SetSpeed1x()
    {
        Time.timeScale = 1f;
        Debug.Log("Set to 1x Speed");
    }

    // Set the game speed to 2x speed
    public void SetSpeed2x()
    {
        Time.timeScale = 2f;
        Debug.Log("Set to 2x Speed");
    }

    // Set the game speed to 3x speed
    public void SetSpeed3x()
    {
        Time.timeScale = 3f;
        Debug.Log("Set to 3x Speed");
    }
}

