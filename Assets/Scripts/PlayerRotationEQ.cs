using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    public float rotationSpeed = 100f; // Rotation speed in degrees per second

    void Update()
    {
        // Get input from Q and E keys
        if (Input.GetKey(KeyCode.E))
        {
            // Rotate right (clockwise)
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            // Rotate left (counter-clockwise)
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime, Space.World);
        }
    }
}
