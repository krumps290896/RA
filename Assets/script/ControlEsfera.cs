using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ControlEsfera : MonoBehaviour {

    Rigidbody rb;
    public float velocidad;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {
        float movH = CrossPlatformInputManager.GetAxis("Horizontal")* velocidad;
        float movV = CrossPlatformInputManager.GetAxis("Vertical") * velocidad;

        rb.AddForce(movH, 0, movV);

    }
    private void OnTriggerEnter(Collider otro)
    {
        if (otro.CompareTag("salida"))
        {
            Debug.Log("Felicidades, ayudaste al elefante a llegar con sus amigos");
        }
        
    }
}
