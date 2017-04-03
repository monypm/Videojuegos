using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {



	public void BotonJugar(){
		Application.LoadLevel ("Escena1");
	}

	public void BotonSalir(){
		Application.Quit ();
	}
}
