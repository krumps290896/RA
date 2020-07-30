using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionador : MonoBehaviour {

	// Use this for initialization
	void onCollisionEnter (Collision col) {
        col.transform.position = new Vector3(0, -5f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
