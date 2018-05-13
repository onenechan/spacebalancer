using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketScript : MonoBehaviour {

	public float speed;

	void Update () {
		if (TimerScript.useTime <= -5) {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
	}
}
