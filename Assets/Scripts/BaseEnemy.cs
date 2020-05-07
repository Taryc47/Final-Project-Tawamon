using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class BaseEnemy{
    
	public string	name;
	
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
	
	public float	baseHP;
	public float	curHP;
	
	public int		baseATK;
	public int		curATK;
	public int		baseMAG;
	public int		curMAG;
	public int		baseDEF;
	public int		curDEF;
	public int		baseMDF;
	public int		curMDF;
}
