using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour{
   // A static field accessible by code anywhere
   static public bool		onLift = false;
   
   void OnTriggerEnter(Collider other){
	   // When the trigger is hit by something
	   // Check to see if it's a Projectile
	   if(other.gameObject.tag == "Player"){
		   // If so, set onLift to true
		   onLift = true;
	   }
   }
}
