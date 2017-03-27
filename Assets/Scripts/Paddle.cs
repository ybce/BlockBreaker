﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		//print (mousePosInBlocks);
		Vector3 pos = new Vector3 (Mathf.Clamp(mousePosInBlocks,0f,15f) ,this.transform.position.y, 0);
		//pos.x = mousePosInBlocks;
		this.transform.position = pos;

	}
}
