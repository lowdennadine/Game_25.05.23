using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Teleport : MonoBehaviour
{
    public Transform player;
    public Transform TeleportLocation;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnterCollider(BoxCollider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.transform.position = TeleportLocation.transform.position;
        }
    }
}
