using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightrocketScript : MonoBehaviour {

	public GameObject Saturn_V; 
	private AudioSource afterLaunch;

	bool flag = false;

	public GameObject Exprotion;
	bool flag1;

	private AudioSource bombSound;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (BombtimeScript.bombtime >= 0){
			transform.RotateAround (transform.position,transform.forward, -10 * Time.deltaTime);
			afterLaunch = GetComponent<AudioSource> ();	
			if (!afterLaunch.isPlaying) {
				afterLaunch.Play ();
			}
		}
		if(BombtimeScript.bombtime >= 7 && !flag1){
			flag1 = true;
			bombSound = GetComponent<AudioSource> ();
			bombSound.Play ();
			Instantiate (Exprotion, new Vector3 (3.8f, 21.9f, -5), Quaternion.identity);
		}
		if (BombtimeScript.bombtime >= 8 && !flag) {
			flag = true;
			Destroy (gameObject);
		}
	}
}
