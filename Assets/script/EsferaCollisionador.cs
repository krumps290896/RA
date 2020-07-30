using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaCollisionador : MonoBehaviour {

	// Use this for initialization
	void onCollisionEnter (Collision col) {
        this.transform.position = new Vector3(0, -5f, 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
