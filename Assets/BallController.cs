using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Calling the Start method");

    }

    // Update is called once per frame
    void Update()
    {
        // Check for "W" key input
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("User's Input: W");
        }

        // Check for "A" key input
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("User's Input: A");
        }

        // Check for "S" key input
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("User's Input: S");
        }

        // Check for "D" key input
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("User's Input: D");
        }
    }
}
