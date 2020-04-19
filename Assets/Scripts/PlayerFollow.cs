﻿// Camera follows Player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour{
	
	public Transform player;
	
	private Vector3 offset;

	
	[Range(0.01f, 1.0f)]
	public float SmoothFactor = 0.5f;
	
    // Start is called before the first frame update
    void Start(){
        offset = transform.position - player.position;
    }

	void Update(){
	
	}

    // LateUpdate is called after Update
    void LateUpdate(){
        Vector3 newPos = player.position + offset;
		
		transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
		
    }
}