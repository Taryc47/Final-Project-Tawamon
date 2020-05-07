using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour{
	
	public GameObject playerPrefab;
	
    // Start is called before the first frame update
    void Start(){
        GameObject player = Instantiate<GameObject>(playerPrefab);
		player.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update(){
        
    }
}
