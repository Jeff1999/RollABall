using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 0.5f;
    [SerializeField] private float jumpForce = 2f; // Add jump force variable

    private bool isGrounded = false; // Track ground contact

    void Start()
    {
        Debug.Log("BallController has been initialized.");
    }

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

    // New method for jumping
    public void Jump()
    {
        if (isGrounded)
        {
            sphereRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    // Detect ground collision enter
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // Optional: Detect ground collision exit
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}


