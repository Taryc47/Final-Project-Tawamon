using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour{
    
	
	public enum	Element{
		AIR,
		WATER,
		EARTH,
		FIRE
	}
	
	public enum Rarity{
		COMMON,
		UNCOMMON,
		RARE,
		KEYHOLDER
	}
	
	public Element	EnemyElement;
	public Rarity	rarity;
	
	
	
	public int		maxHP;
	public int		currentHP;
	public int		ATK;
	public int		MAG;
	public int		DEF;
	public int		MDF;
	
	
	void Start(){
		currentHP = maxHP;
	}
	
	public void TakeDamage(int damage){
		currentHP -= damage;
	
		// Animation
		
		if(currentHP <= 0){
			Die();
		}
	}
	
	void Die(){
		Destroy(this.gameObject);
	}
}
