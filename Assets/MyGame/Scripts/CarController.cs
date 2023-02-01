using UnityEngine;

public class CarController : MonoBehaviour
{
    // Speed of the car
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // Get input from the horizontal axis (WASD keys)
        float horizontal = Input.GetAxis("Horizontal");

        // Get input from the vertical axis (WASD keys)
        float vertical = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 direction = new Vector3(horizontal, vertical, 0);

        // Normalize the direction to prevent faster diagonal movement
        direction = direction.normalized;

        // Move the car in the direction
        transform.position += direction * speed * Time.deltaTime;

        // Rotate the car in the direction it's moving
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
    }
}
