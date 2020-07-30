using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour {


    public float velocidad = 1;
    Rigidbody miRigidbody;

	// Use this for initialization
	void Start () {

        miRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        float vertical= Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        miRigidbody.AddForce(new Vector3(horizontal, 0, vertical)* velocidad);
	}

    void OnTriggerEnter(Collider otro)
    {
        if (otro.CompareTag("salida"))
        {
            Debug.Log("¡Felicidades!, ayudaste al elefante llego con sus amigos");
        }
    }
}
