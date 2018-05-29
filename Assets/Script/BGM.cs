using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {

	public static bool scenechange = true;
	public AudioSource bgm;

	// Use this for initialization
	void Start () {
		Invoke ("_stop", 35);
		if (scenechange) {
			DontDestroyOnLoad (this);
			bgm.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void _stop(){
		bgm.Stop ();
	}
}
