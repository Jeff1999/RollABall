using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnJump = new UnityEvent(); // New event for jump input

    void Start()
    {
        Debug.Log("InputManager has been initialized.");
    }

    void Update()
    {
        // Existing movement input code
        Vector2 inputVector = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }
        OnMove?.Invoke(inputVector);

        // New jump input detection
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnJump?.Invoke();
        }
    }
}