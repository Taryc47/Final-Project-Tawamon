using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour{
  
	public int gold;
	private GameplayManager gameplayManager;
   
	void Awake(){
		gameplayManager = GameObject.FindObjectOfType<GameplayManager>();
	}
   
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Gold")){
			other.gameObject.SetActive(false);
			gameplayManager.UpdateGold(gold);
		}
	}
}
