using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearScript : MonoBehaviour {

	public Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText.text = "SCORE " + TimerScript.Score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
