using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Check if there is any touch input
        if (Input.touchCount > 0)
        {
            // Get the first touch
            Touch touch = Input.GetTouch(0);

            // Convert touch position to world space
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f; // Assuming your object is in 2D space

            // Move the object towards the touch position
            transform.position = Vector3.MoveTowards(transform.position, touchPosition, speed * Time.deltaTime);
        }
    }
}