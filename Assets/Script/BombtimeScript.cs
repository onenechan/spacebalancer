using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombtimeScript : MonoBehaviour {

	public static float bombtime = 0;

	// Use this for initialization
	void Start () {
		bombtime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		print (bombtime);
		bombtime += Time.deltaTime;
		if (bombtime >= 10) {
			if (SceneManager.GetActiveScene ().name == "center") {
				SceneManager.LoadScene ("clear");
			}
		}

		if (bombtime >= 23) {
			if (SceneManager.GetActiveScene ().name == "right" || SceneManager.GetActiveScene ().name == "left") {
				SceneManager.LoadScene ("gameover");
			}
		}
	}
}
