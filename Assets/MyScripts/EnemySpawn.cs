﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject objectToSpawn;
    public int numberOffEnemies;
    private float spawnRadius = 5;
    private Vector3 spawnPosition;

	// Use this for initialization
	void Start () {
        SpawnObject();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnObject()
    {
        StartCoroutine("waitForFiveSeconds");

        for (int i=0;i<numberOffEnemies;i++)
        {
            spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            Vector3 adjustedPos = new Vector3(spawnPosition.x, 1, spawnPosition.z);
            Instantiate(objectToSpawn, adjustedPos, Quaternion.identity);
        }


    }

    IEnumerator waitForFiveSeconds()
    {
        yield return new WaitForSeconds(5);

    }
}
