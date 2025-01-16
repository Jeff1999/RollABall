using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody; // Rigidbody reference
    [SerializeField] private float ballSpeed = 2f;      // Movement speed multiplier

    // Optional: Start method to confirm initialization
    void Start()
    {
        Debug.Log("BallController has been initialized.");
    }

    // Method to move the ball based on the input vector
    public void MoveBall(Vector2 input)
    {
        // Convert 2D input vector to 3D for movement in the XZ plane
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);

        // Apply force to the Rigidbody to move the sphere
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);

        // Debug logs for verification
        Debug.Log("Input Vector: " + input);
        Debug.Log("3D Movement Vector: " + inputXZPlane);
    }
}

