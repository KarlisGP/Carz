using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed = 40f;

    private float horizontalInput;
    private float forwardInput;

    public Camera mainCamera;
    public Camera hoodCamera;

    public string inputID;
    public KeyCode switchKey;

    void Update()
    {
        // Multiplayer input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        // Move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Turn
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        // Camera switch
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}