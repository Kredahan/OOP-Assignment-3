﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PrideRock
{
  
    public class Shoot : MonoBehaviour
    {

        
        private float firerate = 0.1f;
        private float nextFire;
        private RaycastHit hit;
        private float range = 300;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            CheckForInput();

        }

        void CheckForInput()
        {

            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                GetComponent<AudioSource>().Play();
                Debug.DrawRay(transform.position, transform.forward, Color.cyan, 3);
                if (Physics.Raycast(transform.position, transform.forward, out hit, range))
                {
                    Debug.Log(hit.transform.name);
                }
                nextFire = Time.time + firerate;
                //Debug.Log("KeyPressed");
            }

        }
    }


}