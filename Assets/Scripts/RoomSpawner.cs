using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour{
   
	public int openingDirection;
	// 1 = need bottom opening 
	// 2 = need top opening 
	// 3 = need left opening 
	// 4 = need right opening 
   
	private RoomsHalls templates;
	private int rand;
	private bool spawned = false;
	private int forcestop;
   
	void Start(){
	   // Accesses the arrays in which the rooms and halls are stored
	   templates =  GameObject.FindGameObjectWithTag("RoomsHalls").GetComponent<RoomsHalls>();
	  
	   Invoke("Spawn", 0.1f);
	}
   
	void Spawn(){
		if(spawned == false){
			if(openingDirection == 1){
				// Need to spawn a hall with a BOTTOM opening
				rand = Random.Range(0, templates.bottomHalls.Length);
				Instantiate(templates.bottomHalls[rand], transform.position, templates.bottomHalls[rand].transform.rotation);
			}else if(openingDirection == 2){
				// Need to spawn a hall with a TOP opening
				rand = Random.Range(0, templates.topHalls.Length);
				Instantiate(templates.topHalls[rand], transform.position, templates.topHalls[rand].transform.rotation);
			}else if(openingDirection == 3){
				// Need to spawn a hall with a LEFT opening
				rand = Random.Range(0, templates.leftHalls.Length);
				Instantiate(templates.leftHalls[rand], transform.position, templates.leftHalls[rand].transform.rotation);
			}else if(openingDirection == 4){
				// Need to spawn a hall with a RIGHT opening
				rand = Random.Range(0, templates.rightHalls.Length);
				Instantiate(templates.rightHalls[rand], transform.position, templates.rightHalls[rand].transform.rotation);
				
			}else if(openingDirection == 5){
				// Need to spawn an extended hall with a BOTTOM opening
				rand = Random.Range(0, templates.bottomExtendedHalls.Length);
				Instantiate(templates.bottomExtendedHalls[rand], transform.position, templates.bottomExtendedHalls[rand].transform.rotation);
			}else if(openingDirection == 6){
				// Need to spawn an extended hall with a TOP opening
				rand = Random.Range(0, templates.topExtendedHalls.Length);
				Instantiate(templates.topExtendedHalls[rand], transform.position, templates.topExtendedHalls[rand].transform.rotation);
			}else if(openingDirection == 7){
				// Need to spawn an extended hall with a LEFT opening
				rand = Random.Range(0, templates.leftExtendedHalls.Length);
				Instantiate(templates.leftExtendedHalls[rand], transform.position, templates.leftExtendedHalls[rand].transform.rotation);
			}else if(openingDirection == 8){
				// Need to spawn an extended hall with a RIGHT opening
				rand = Random.Range(0, templates.rightExtendedHalls.Length);
				Instantiate(templates.rightExtendedHalls[rand], transform.position, templates.rightExtendedHalls[rand].transform.rotation);
				
			}else if(openingDirection == 9){
				// Need to spawn a room with a BOTTOM opening
				rand = Random.Range(0, templates.bottomRooms.Length);
				Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
			}else if(openingDirection == 10){
				// Need to spawn a room with a TOP opening
				rand = Random.Range(0, templates.topRooms.Length);
				Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
			}else if(openingDirection == 11){
				// Need to spawn a room with a LEFT opening
				rand = Random.Range(0, templates.leftRooms.Length);
				Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
			}else if(openingDirection == 12){
				// Need to spawn a room with a RIGHT opening
				rand = Random.Range(0, templates.rightRooms.Length);
				Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
			
			}
			
		}	
		spawned = true;	
	}
	
	void OnTriggerEnter(Collider other){
		// This makes it so a room will not spwan ontop of another room
		if(other.CompareTag("SpawnPoint") && other.GetComponent<RoomSpawner>().spawned == true){
			Destroy(gameObject);
		}
	}
}
