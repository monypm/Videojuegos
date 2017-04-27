using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

	public void BotonJugar(){
		CharacterScreen.ResetPlayerState (15);
		SceneManager.LoadScene("Clase");
	}

	public void BotonSalir(){
		Application.Quit ();
	}

	public void BotonCaballero(){
		PlayerPrefs.SetInt ("CharacterSelected", 1);
		SceneManager.LoadScene ("IntroVid");
	}

	public void BotonMago(){
		PlayerPrefs.SetInt ("CharacterSelected", 2);
		SceneManager.LoadScene ("IntroVid");
	}

	public void BotonLadron(){
		PlayerPrefs.SetInt ("CharacterSelected", 3);
		SceneManager.LoadScene ("IntroVid");
	}
}
