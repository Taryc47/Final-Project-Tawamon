﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{
	
	public Transform player;
	
	
	private Vector3 offset;
	
    // Start is called before the first frame update
    void Start(){
		if(!player){
			player = GameObject.FindGameObjectWithTag("Player").transform;
		}
        offset = transform.position ;
    }
	
	
	void LateUpdate(){
		if(!player){
			player = GameObject.FindGameObjectWithTag("Player").transform;
		}
		transform.position = player.transform.position + offset;
	}
}
