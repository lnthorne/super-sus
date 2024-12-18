using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed

    void Update()
    {
        // Get input from keyboard
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow
        float vertical = Input.GetAxis("Vertical");     // W/S or Up/Down Arrow

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}
