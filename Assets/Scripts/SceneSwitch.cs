using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour{
  
	Scene scene;
	
	void Start(){
		scene = SceneManager.GetActiveScene();
		Debug.Log("Active scene is'" + scene.name + "'.");
	}
	
	void OnTriggerEnter(Collider player){
		SceneManager.LoadScene(scene.buildIndex + 1);
	}
}

