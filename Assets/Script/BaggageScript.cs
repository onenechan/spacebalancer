using System.Collections;
using UnityEngine.AI;
using UnityEngine;

public class BaggageScript : MonoBehaviour {

	//ドラック＆ドロップ
	public Vector3 screenPoint;
	public Vector3 offset;

	bool flag = false;

	private int mass;

	void Start(){
		mass = (int)gameObject.GetComponent<Rigidbody> ().mass; //Riditbodyのmassを採用する
	}
	
	// Update is called once per frame
	void Update () {
		if (TimerScript.useTime <= -7 && !flag) {
			flag = true;
			judge ();
		}
	}

	void judge(){
		Vector3 pos = transform.position;
		if (pos.x >= 0 && pos.x <= 7 && pos.y >= -10 && pos.y <= 30) {
			TimerScript.leftMass += mass;
			if (gameObject.tag == "nomal") {
				TimerScript.Score += 5;
			}else if (gameObject.tag == "dangerous") {
				TimerScript.Score += 10;
			}else if(gameObject.tag=="people"){;
				TimerScript.Score += 15;
			}
		}
		if (pos.x > 7 && pos.x <= 13 && pos.y >= -10 && pos.y <= 30) {
			TimerScript.centerMass += mass;
			Debug.Log (mass);
			if (gameObject.tag == "nomal") {
				TimerScript.Score += 5;
			}else if (gameObject.tag == "dangerous") {
				TimerScript.Score += 10;
			}else if(gameObject.tag=="people"){
				TimerScript.Score += 15;
			}
		}
		if (pos.x >13 && pos.x <= 20 && pos.y >= -10 && pos.y <= 30) {
			TimerScript.rightMass += mass;
			if (gameObject.tag == "nomal") {
				TimerScript.Score += 5;
			}else if (gameObject.tag == "dangerous") {
				TimerScript.Score += 10;
			}else if(gameObject.tag=="people"){
				TimerScript.Score += 15;
			}
		}
	}

	void OnMouseDown(){
		//if(TimerScript.useTime >= 0){
		screenPoint = Camera.main.WorldToScreenPoint (transform.position);
		offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,screenPoint.z));
		//}
	}

	void OnMouseDrag(){
		//if(TimerScript.useTime >= 0){
		Vector3 currentScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPosition = Camera.main.ScreenToWorldPoint (currentScreenPoint) + this.offset;
		transform.position = currentPosition;
		//}
	}
}
