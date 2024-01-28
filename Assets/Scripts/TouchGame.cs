using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(touchPosition.x, touchPosition.y, transform.position.z);
        }
    }
}
