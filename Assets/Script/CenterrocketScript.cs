using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterrocketScript : MonoBehaviour {

	AudioSource afterLaunch;

	// Use this for initialization
	void Start () {
		afterLaunch = GetComponent<AudioSource> ();
		afterLaunch.Play ();
	}
}
