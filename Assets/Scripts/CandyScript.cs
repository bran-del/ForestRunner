﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CandyScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			ScoreManager.score += 100;
			Destroy (gameObject);
		}
		
	}
}