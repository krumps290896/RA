using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class PanelInfo : MonoBehaviour, ITrackableEventHandler {
	private TrackableBehaviour mTrackableBehaviour;


	UnityEngine.UI.Image Image_Background;
	//Elemento de imagen dentro de un canvas
	public GameObject Image_UI;
	//Imagen que quiero mostrar en el canvas cuando encuentre el activador 
	public Sprite Image_Info;
	//Panel que ocupa 1/3 de la pantalla y contiene la imagen
	public GameObject Panel_Info;
	//Imagen que queremos que aparezca cuando active la cámara... Opcional
	public GameObject Image_Scanner;
	//Variables de texto que se pueden incorporar en el Canvas pantalla
	public Text Titulo;
	public Text Descripcion;




	// Use this for initialization
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour> ();

		if (mTrackableBehaviour) {
			mTrackableBehaviour.RegisterTrackableEventHandler (this);
		}

		Panel_Info.SetActive (false);
		Image_Scanner.SetActive (true);
	}
	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
		Panel_Info.SetActive (false);
		Image_Scanner.SetActive (true);

		if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) 
		{
			Debug.Log ("1");

			Panel_Info.SetActive (true);
			Image_Scanner.SetActive (false);
			Image_Background = Image_UI.GetComponent<UnityEngine.UI.Image> ();
			Image_Background.sprite = Image_Info;

			//Aqui cambio el texto que quiero que aparezca cuando le muestre el activador,
			Titulo.text = "Hello World";
			Descripcion.text = "Esto es un simulacro, no corra";



		} else {

			Panel_Info.SetActive (false);
			Image_Scanner.SetActive (true);
			Titulo.text = " ";
			Descripcion.text = " ";
				
		


			// Update is called once per frame
		}
	}
}

