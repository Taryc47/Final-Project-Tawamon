using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
	
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
	
	// Player Movement
	void Move(){
		transform.position = Vector3.MoveTowards
			(transform.position, destination, speed * Time.deltaTime);
		
		if(Input.GetKeyDown(KeyCode.W)){
			nextPos = Vector3.forward;
			currentDirection = up;
			// If space is held player will face the corresponding direction without moving
			if(Input.GetKey(KeyCode.Space)){
			canMove = false;
			}else{
				canMove = true;
			}
		}
			
		if(Input.GetKeyDown(KeyCode.S)){
			nextPos = Vector3.back;
			currentDirection = down;
			// If space is held player will face the corresponding direction without moving
			if(Input.GetKey(KeyCode.Space)){
			canMove = false;
			}else{
				canMove = true;
			}
		}
			
		if(Input.GetKeyDown(KeyCode.D)){
			nextPos = Vector3.right;
			currentDirection = right;
			// If space is held player will face the corresponding direction without moving
			if(Input.GetKey(KeyCode.Space)){
			canMove = false;
			}else{
				canMove = true;
			}
		}
			
		if(Input.GetKeyDown(KeyCode.A)){
			nextPos = Vector3.left;
			currentDirection = left;
			// If space is held player will face the corresponding direction without moving
			if(Input.GetKey(KeyCode.Space)){
			canMove = false;
			}else{
				canMove = true;
			}
		}
		
		// Holding down right shift and the direction key will let player move multiple spaces
		if(Input.GetKey(KeyCode.RightShift)){
			canMove = true;
			if(Input.GetKey(KeyCode.W)){
				nextPos = Vector3.forward;
				currentDirection = up;
			}else if (Input.GetKey(KeyCode.S)){
				nextPos = Vector3.back;
				currentDirection = down;
			}else if (Input.GetKey(KeyCode.D)){
				nextPos = Vector3.right;
				currentDirection = right;
			}else if (Input.GetKey(KeyCode.A)){
				nextPos = Vector3.left;
				currentDirection = left;
			}else{
				canMove = false;
			}
		}
		
		// rotates player
		if(Vector3.Distance(destination, transform.position) <= 0.00001f){
			transform.localEulerAngles = currentDirection;
			
			// Moves Player
			if (canMove){
				if(ValidLoc()){
					destination = transform.position + nextPos;
					direction = nextPos;
					canMove = false;
				}
			}
		}
	}
	
	// Tests if Player can move into space
	bool ValidLoc(){
		Ray locRay = new Ray(transform.position + new Vector3(0, 0.25f, 0), transform.forward);
		RaycastHit hit;
		
		// tests if a wall is hit with raycast
		if(Physics.Raycast(locRay, out hit, rayLength)){
			if(hit.collider.tag == "Wall" || hit.collider.tag == "Monster"){ 
				return false;
			}
		}
		
		return true;
	}
	
	// Used for collection
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Item")){
			other.gameObject.SetActive(false);
		}
	}
	
	
}
