﻿using UnityEngine;
using System.Collections;

public class SpawningRed : MonoBehaviour
{
	public GameObject prefab1;
	
	public GameObject prefab2;
	
	public GameObject prefab3;
	
	public GameObject prefab4;

	
	public int platform;
	
	// Use this for initialization
	void Start () {
		
		InvokeRepeating("CreateObstacle", 1f, 2.85f); 
		
	}
	
	
	
	void CreateObstacle()
	{
		platform = Random.Range (1, 4);             //radom number generator b/w 1 and 7
		float RandomX = Random.Range(57.28f, 57.72f);
		float RandomY = Random.Range (7.35f, 7.55f);
		float RandomZ = Random.Range (28.53f, 20.38f);// appear b/w -5 and 5 in y-axis
		               // spawn this much right of the screen
		
		switch (platform)
		{
		case 1: 
			Instantiate(prefab1, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity); 
			break;
		case 2:
			Instantiate(prefab2, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity);
			break;
		case 3: 
			Instantiate(prefab3, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity);
			break;
		case 4: 
			Instantiate(prefab4, new Vector3(RandomX, RandomY, RandomZ), Quaternion.identity);
			break;
		
		}
		
	}
}