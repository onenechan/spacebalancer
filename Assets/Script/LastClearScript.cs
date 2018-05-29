using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastClearScript : MonoBehaviour {

	private AudioSource trumpet;
	private AudioSource dondonpafpaf;

	// Use this for initialization
	void Start () {
		trumpet = GetComponent<AudioSource> ();
		dondonpafpaf = GetComponent<AudioSource> ();
		trumpet.Play ();
		dondonpafpaf.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
