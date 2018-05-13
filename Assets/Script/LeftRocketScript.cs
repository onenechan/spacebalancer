using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRocketScript : MonoBehaviour {

	public GameObject Saturn_V; 

	bool flag = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (BombtimeScript.bombtime >= 7){
			transform.RotateAround (transform.position,transform.forward, 10 * Time.deltaTime);
		}
		if (BombtimeScript.bombtime >= 20 && !flag) {
			flag = true;
			Destroy (gameObject);
		}
	}
}
