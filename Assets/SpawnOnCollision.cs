using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnCollision : MonoBehaviour
{
    public GameObject Sphere; // The game object to spawn
    public int numberOfObjectsToSpawn = 12; // Number of objects to spawn on collision

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Player has collided with this object
            SpawnObjects();
        }
    }

    void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjectsToSpawn; i++)
        {
            // Instantiate a new copy of the object at the current position
            Instantiate(Sphere, transform.position, Quaternion.identity);
        }

        // Destroy the original object if needed
        Destroy(gameObject);

    }

}


