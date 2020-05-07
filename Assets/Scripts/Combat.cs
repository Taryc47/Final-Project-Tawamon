using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour{
	
	public Transform attackPoint;
	public float attackRange = 0.25f;
	public LayerMask monsterLayers;
	
	
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        // Attack
	   if(Input.GetKeyDown(KeyCode.Return)){
		   Attack();
	   }
    }
	
	// Player Attack
	void Attack(){
		// Detect Monster
		Collider[] hitMonsters = Physics.OverlapSphere(attackPoint.position, attackRange, monsterLayers);
		// Damage
		foreach(Collider monster in hitMonsters){
			Debug.Log("We hit " + monster.name);
		}
	}
	
	void OnDrawGizmosSelected(){
		if(attackPoint == null){
			return;
		}
		Gizmos.DrawWireSphere(attackPoint.position, attackRange);
	}
}
