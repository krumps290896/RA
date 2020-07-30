using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    public Rigidbody2D rBD;
    public float speed = 1f, jumpForce = 50;

    public float radio = 0.2f;
    public LayerMask layerSuelo;
    public Transform pie;
    public bool estaEnSuelo, Derbool = false, Izqbool = false;


    void Start() {
        rBD = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        DetectorSuelo();

        if(Input.GetKey (KeyCode.RightArrow) || Derbool)
        {
            Derbool = true;
            Der();
        }


        if (Input.GetKey(KeyCode.LeftArrow) || Izqbool)
        {
            Izqbool = true;
            Izq();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Salto();
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || (!Derbool && !Izqbool))
        {
            Derbool = false;
            Izqbool = false;
            VelocityXO();
        }

    }

    //________________________________________________________________________________
    //BotonesTouch

        public void DerTrue()
    {
        Derbool = true;
    }

    public void DerFalse()
    {
        Derbool = false;
    }


    public void IzqTrue()
    {
        Izqbool = true;
    }

    public void IzqFalse()
    {
        Izqbool = false;
    }









    //-----------------------------------------------------------

    public void Der()   {
        rBD.velocity += new Vector2(1 * speed, 0);
    }

    public void VelocityXO()
    {
        rBD.velocity = new Vector2(0, rBD.velocity.y);
    }

    public void Izq()    {
        rBD.velocity -= new Vector2(1 * speed, 0);
    }


    public void DetectorSuelo()
    {
        estaEnSuelo = Physics2D.OverlapCircle(pie.position, radio, layerSuelo);
    }


    public void Salto()
    {
        if (!estaEnSuelo)
            return;

        rBD.AddForce( transform.up * jumpForce, ForceMode2D.Impulse);
    }
}

