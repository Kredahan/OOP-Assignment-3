using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public Transform target;
    public Transform enemyposition;
	
	// Update is called once per frame
	void Update () {

        target = GameObject.FindWithTag("Player").transform;
        transform.LookAt(target);
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        
        
		
	}
}
