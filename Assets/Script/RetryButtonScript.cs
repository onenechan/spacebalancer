using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonScript : MonoBehaviour {

	private AudioSource click;

	public void RetryButton(){
		click = GetComponent<AudioSource>();
		click.Play ();
		SceneManager.LoadScene("start");
	}

}
