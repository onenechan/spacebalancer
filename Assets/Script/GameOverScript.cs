using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	public Text gameoverText; 
	float gameoverTime = 0;
	bool flag = false;

	void update(){
		gameoverTime  += Time.deltaTime;
	}

	void _gameover () {
		if (gameoverTime >= 23 && !flag) {
			gameoverText.text = "GAME OVER";
		}
	}
}
