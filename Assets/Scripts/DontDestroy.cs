using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour{
	
	public GameObject	rootCanvas;
	
    // Start is called before the first frame update
    void Start(){
        DontDestroyOnLoad(rootCanvas);
    }

    // Update is called once per frame
    void Update(){
        
    }
}
