using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    public GameObject[] myObjects;
    // Adjust this speed to control the movement speed
    public float moveSpeed = 5f;


    void Update()
    {
        MovePlayer();

        if (Input.GetMouseButton(0))
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        }

        void MovePlayer()
        {
            if (Input.GetMouseButton(0))
            {
                // Get the current touch/mouse position
                Vector3 targetPosition = GetMouseWorldPosition();

                // Move the player towards the touch/mouse position
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            }
        }

        Vector3 GetMouseWorldPosition()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                return hit.point;
            }

            return Vector3.zero;
        }
    }
}
