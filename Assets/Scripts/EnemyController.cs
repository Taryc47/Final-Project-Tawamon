using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour{
   
   	Vector3	up = Vector3.zero,
			right = new Vector3(0, 90, 0),
			down = new Vector3(0, 180, 0),
			left = new Vector3(0, 270, 0),
			currentDirection = Vector3.zero;
	
	Vector3 nextPos, destination, direction;
	
	float speed = 5f;
	float rayLength = 1f;
	
	bool canMove;
	
    // Start is called before the first frame update
    void Start(){
        currentDirection = up;
		nextPos = Vector3.forward;
		destination = transform.position;
    }

    // Update is called once per frame
    void Update(){
       Move();
    }
	
	// enemy Movement
	void Move(){
		transform.position = Vector3.MoveTowards
			(transform.position, destination, speed * Time.deltaTime);
		
		if(Input.anyKeyDown){
			nextPos = transform.forward;
			canMove = true;
		}
		
		if(ValidLoc() == false){
			
		}
		
		
		// rotates enemy
		if(Vector3.Distance(destination, transform.position) <= 0.00001f){
			transform.localEulerAngles = currentDirection;
			
			// Moves enemy
			if (canMove){
				if(ValidLoc()){
					destination = transform.position + nextPos;
					direction = nextPos;
					canMove = false;
				}
			}
		}
	}
	
	// Tests if Enemy can move into a space
	bool ValidLoc(){
		Ray locRay = new Ray(transform.position + new Vector3(0, 0.25f, 0), transform.forward);
		RaycastHit hit;
		
		// tests if a wall is hit with raycast
		if(Physics.Raycast(locRay, out hit, rayLength)){
			if(hit.collider.tag == "Wall" || hit.collider.tag == "Player"){ 
				return false;
			}
		}
		
		return true;
	}
	
}
