using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectScript : MonoBehaviour {

	bool flag = false;

	void Start(){
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.transform.CompareTag ("dangerous")) {
			Destroy (col.gameObject);
			TimerScript.Score -= 10;
		} else if (col.gameObject.transform.CompareTag ("people")) {
			Destroy (col.gameObject);
			TimerScript.Score -= 15;
		}
	}
}
