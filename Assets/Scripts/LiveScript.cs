﻿using UnityEngine;
using System.Collections;

public class LiveScript : MonoBehaviour {
	public GameObject liveprefab;
	public ArrayList lives;
	public int initLives = 3;
	// Use this for initialization
	void Start () {
		lives = new ArrayList();
		var live = GameObject.Find("Live");
		lives.Insert(0,live);
		
		for(int i = 1; i < initLives; i++){
			var nuevavida = (GameObject)Instantiate(
				liveprefab,
				new Vector3(live.transform.position.x-(i*30),live.transform.position.y,live.transform.position.z),
				transform.rotation);
			nuevavida.transform.SetParent(this.transform);
			lives.Insert(i,nuevavida);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.C)){
			var live = lives[lives.Count-1];
			//Destroy(live);
		}
	}
}
