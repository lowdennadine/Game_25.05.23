using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<Renderer>().material.color == Color.black)
            {
                other.gameObject.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log("+");
            }
            else if (other.gameObject.GetComponent<Renderer>().material.color == Color.white)
            {
                other.gameObject.GetComponent<Renderer>().material.color = Color.black;
                Debug.Log("-");
            }
        }
    }
}

