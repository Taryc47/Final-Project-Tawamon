// Sets player stats

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour{
   public List<BaseStat> stats = new List<BaseStat>();
   
   void Start(){
		stats.Add(new BaseStat(15, "HP", "Your Health."));
		stats.Add(new BaseStat(5, "ATK", "Attack Power."));
		stats.Add(new BaseStat(4, "DEF", "Physical Defense."));
		stats.Add(new BaseStat(4, "MDEF", "Magic Defense."));
		Debug.Log(stats[0].GetCalcStatValue());
	   
   }
}
