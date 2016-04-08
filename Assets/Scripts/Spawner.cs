﻿using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject[]fish;
	int fishNo;
	public float maxPos=3.4f;
	public float delayTimer=1f;
	float timer;
	// Use this for initialization
	void Start () {
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Vector3 fishPos = new Vector3 (transform.position.x, Random.Range (-5.6f, 3.4f), transform.position.z);
			fishNo = Random.Range (0, 4);
			Instantiate (fish[fishNo ], fishPos, transform.rotation);
			timer = delayTimer;
		}
	}
}
