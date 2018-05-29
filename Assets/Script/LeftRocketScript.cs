using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRocketScript : MonoBehaviour {

	public GameObject Saturn_V; 
	private AudioSource afterLaunch;
	private AudioSource bombSound;

	bool flag = false;

	public GameObject Exprotion;
	bool flag1;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(BombtimeScript.bombtime >= 0){
			transform.RotateAround (transform.position,transform.forward, 10 * Time.deltaTime);
			afterLaunch = GetComponent<AudioSource> ();	
			if (!afterLaunch.isPlaying) {
				afterLaunch.Play ();
			}
		}
		if(BombtimeScript.bombtime >= 7 && !flag1){
			flag1 = true;
			bombSound = GetComponent<AudioSource> ();
			bombSound.Play ();
			Instantiate (Exprotion, new Vector3 (16.7f, 17, -5), Quaternion.identity);
		}
		if (BombtimeScript.bombtime >= 8 && !flag) {
			flag = true;
			Destroy (gameObject);
		}
	}
}
