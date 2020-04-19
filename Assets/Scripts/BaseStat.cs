using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStat{
	
	public List<StatBonus> BaseAdd{get; set;}
	public int BaseValue {get; set;}
	public string StatName {get; set;}
	public string StatDescription {get; set;}
	public int FinalValue {get; set;}
	
	public BaseStat(int baseValue, string statName, string statDescription){
		this.BaseAdd = new List<StatBonus>();
		this.BaseValue = baseValue;
		this.StatName = statName;
		this.StatDescription = statDescription;
	}
	
	// Adds stat bonus
	public void AddStatBonus(StatBonus statBonus){
		this.BaseAdd.Add(statBonus);
	}
	
	// Removes stat bonus
	public void RemoveStatBonus(StatBonus statBonus){
		this.BaseAdd.Remove(statBonus);
	}
	
	// Loop through each BaseAdd to add it to FinalValue
	public int GetCalcStatValue(){
		this.BaseAdd.ForEach(x => this.FinalValue += x.BonusValue);
		FinalValue += BaseValue;
		return FinalValue;
	}
}