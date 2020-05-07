using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour{
	
	public BasePlayer player;
	
	public enum TurnState{
		SAFE,
		UNSAFE,
		BATTLE,
		IMMOBILE,
		DEAD
	}
	
	public TurnState currentState;
	public Image HealthBar;
	
    // Start is called before the first frame update
    void Start(){
        currentState = TurnState.SAFE;
		
    }

    // Update is called once per frame
    void Update(){
        switch(currentState){
			case(TurnState.SAFE):
			
			break;
			case(TurnState.UNSAFE):
			
			break;
			case(TurnState.BATTLE):
			
			break;
			case(TurnState.IMMOBILE):
			
			break;
			case(TurnState.DEAD):
			
			break;
		}
    }
	
	void UpgradeHealthBar(){
		// need code for HP change
		/*
		float calc_health = cur_health / max_health;
		HealthBar.transform.localScale = new Vector3(Mathf.Clamp(calc_health, 0, 1), 
			HealthBar.transform.localScale.y, HealthBar.transform.localScale.z)
		*/ 
	}
}
