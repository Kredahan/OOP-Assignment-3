using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSense : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Player")
       {
        // GameObject.Find("Player").SendMessage("Die");
            Debug.Log("Player getting touched");
            //Time.timeScale = 0; //ending the game
            Application.LoadLevel("GameOver");
            //Destroy(other.gameObject);
       }

    }

   /* void GameOverScene(string name)
    {
        

    }*/
}

