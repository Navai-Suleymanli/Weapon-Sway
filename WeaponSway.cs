using System;
using UnityEngine;

public class WeaponSway : MonoBehaviour
{
    public GameObject kub; // Reference to a game object named "kub"
    float preciseness = 0.9f; // A floating-point variable to define the level of precision

    [Header("Sway Settings")]
    [SerializeField] private float smooth; // The smoothness factor for the weapon sway effect
    [SerializeField] private float multiplier; // The multiplier for mouse input

    private void Update()
    {
        // Get mouse input along the X and Y axes and multiply it by the multiplier
        float mouseX = Input.GetAxisRaw("Mouse X") * multiplier;
        float mouseY = Input.GetAxisRaw("Mouse Y") * multiplier;

        // Calculate the target rotation using mouse input
        Quaternion rotationX = Quaternion.AngleAxis(-mouseY, Vector3.right);
        Quaternion rotationY = Quaternion.AngleAxis(mouseX, Vector3.up);

        Quaternion targetRotation = rotationX * rotationY;

        // Rotate the object smoothly towards the target rotation
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }

    void OnDrawGizmos()
    {
        Vector3 kubPos = kub.transform.position; // Get the position of the "kub" game object
        Vector3 playerPos = gameObject.transform.position; // Get the position of the current game object
        Vector3 playerLookDir = transform.forward; // Get the forward direction of the current game object

        Vector3 playerToObjectDir = (kubPos - playerPos).normalized; // Calculate the normalized direction from the player to the "kub" object

        float lookness = Vector3.Dot(playerLookDir, playerToObjectDir); // Calculate the dot product of the player's look direction and the direction to the "kub" object

        bool isLooking = lookness >= preciseness; // Check if the dot product is greater than or equal to the specified preciseness

        if (isLooking)
        {
            Destroy(kub); // Destroy the "kub" object if the player is looking at it with sufficient preciseness
        }

        Gizmos.color = Color.white;
        Gizmos.DrawLine(playerPos, playerPos + playerToObjectDir); // Draw a white line from the player to the "kub" object
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(playerPos, playerPos + playerLookDir); // Draw a yellow line representing the player's look direction
    }
}
