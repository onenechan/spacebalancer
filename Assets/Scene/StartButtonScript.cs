using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour {

	private AudioSource click;

	public void StartButton(){
		click = GetComponent<AudioSource>();
		click.Play ();
		SceneManager.LoadScene("main");
	}
}
