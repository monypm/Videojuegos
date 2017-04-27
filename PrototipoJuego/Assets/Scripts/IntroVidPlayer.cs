using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroVidPlayer : MonoBehaviour {

	public MovieTexture movie;
	private bool started = false;

	// Use this for initialization
	void Start () {
		GetComponent<RawImage> ().texture = movie as MovieTexture;
		movie.Play ();
		started = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (!movie.isPlaying && started) {
			SceneManager.LoadScene ("Escena1");
		}
	}
}
