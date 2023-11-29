using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 180f;

    void Update()
    {
        // Move the capsule with arrow keys in its local space
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction in local space
        Vector3 localMovement = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        Vector3 movement = transform.TransformDirection(localMovement);

        // Move the capsule
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // Rotate the capsule with mouse input
        if (Input.GetMouseButton(0)) // Check if the left mouse button is held down
        {
            float mouseX = Input.GetAxis("Mouse X");
            Vector3 rotationAmount = new Vector3(0, mouseX, 0) * rotationSpeed * Time.deltaTime;
            transform.Rotate(rotationAmount);
        }
    }
}
    