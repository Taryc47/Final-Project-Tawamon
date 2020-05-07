using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour{
	
	public int gold = 0;
	
	public Text goldText;
	
	void Start(){
		gold = PlayerPrefs.GetInt("CurrentGold");
		goldText.text = gold.ToString() + " Gold";
	}
	
    public void UpdateGold(int gold){
		gold = PlayerPrefs.GetInt("CurrentGold");
		gold = gold + Random.Range(5, 20);
		PlayerPrefs.SetInt("CurrentGold", gold);
		goldText.text = gold.ToString() + " Gold";
	}
}
