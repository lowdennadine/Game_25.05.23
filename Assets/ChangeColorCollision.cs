using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    public Color collisionColor = Color.red; // The color to change to on collision

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves the specified tag or layer (customize as needed)
        if (collision.gameObject.CompareTag("OtherObjectTag"))
        {
            // Change the color of the object to the specified collisionColor
            GetComponent<Renderer>().material.color = collisionColor;
        }
    }
}

