using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSense : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player")
        //{
           // GameObject.Find("Player").SendMessage("Die");
            Debug.Log("Player getting touched");
       // }

    }
}
