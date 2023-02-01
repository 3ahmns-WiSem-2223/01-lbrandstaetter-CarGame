using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    // The car game object that the camera should follow
    public Transform car;

    // Offset distance of the camera from the car
    public Vector3 offset = new Vector3(0, 0, -10);

    // Smoothness of the camera movement
    public float smoothness = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // Calculate the target position for the camera
        Vector3 targetPosition = car.position + offset;

        // Smoothly move the camera towards the target position
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothness);
    }
}
