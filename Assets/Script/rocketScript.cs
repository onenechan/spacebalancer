using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketScript : MonoBehaviour {

	public float speed;
	private AudioSource audioSorce;
	public AudioClip rocketSound; 


	void Start(){
		audioSorce = gameObject.GetComponent<AudioSource>(); //gameObjectのオーディオソースから情報とってくる
		audioSorce.clip = rocketSound;   //CDset
	}

	void Update () {
		if (TimerScript.useTime <= 0) {
			//audioが鳴っていないとき
			if (!audioSorce.isPlaying) {
				audioSorce.Play();  
			}
		}
		if (TimerScript.useTime <= -5) {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
	}
}
