using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>(); // UnityEvent for broadcasting input

    // Optional: Start method to confirm initialization
    void Start()
    {
        Debug.Log("InputManager has been initialized.");
    }

    // Update method to detect inputs
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        // Detect directional inputs
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up; // Forward (0, 1)
        }

        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;  // Backward (0, -1)
        }

        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;  // Left (-1, 0)
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right; // Right (1, 0)
        }

        // Invoke the event with the calculated input vector
        OnMove?.Invoke(inputVector);

    }
}
