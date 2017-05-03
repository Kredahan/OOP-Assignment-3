using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float startTime;
    private bool dead;
	// Use this for initialization
	void Start () {
        dead = false;
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if(dead)
        {
            return;
        }

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
	}

    public void Die()
    {
        //dead = true;
        Application.Quit();
        timerText.color = Color.red;

    }
}
