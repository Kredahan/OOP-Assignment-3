using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PrideRock
{
  
    public class Shoot : MonoBehaviour
    {

        public GameObject Fire;
        public GameObject Blood;
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
                    if (hit.transform.tag == "Enemy") //if the Object being hit by the raycast has the tag "Enemy"...
                    {
                        Blood.transform.position = hit.transform.position;
                        Blood.SetActive(true);
                        Blood.transform.Translate(0, -1,0);
                        Destroy(hit.transform.gameObject, 0.3f); //..the object gets destroyed
                    }

                }
                nextFire = Time.time + firerate;
                
                StartCoroutine("waitSeconds");
                //Debug.Log("KeyPressed");
            }

        }

        IEnumerator waitSeconds()
        {
            Fire.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            Fire.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            Blood.SetActive(false);



        }
    }


}