using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour {

	public float totalTime;
	public static int useTime;
	public Text timerText,pointText;
	public GameObject afterburner;  //rocketの火

	public static int leftMass,centerMass,rightMass,Score;

	//荷物の宣言
	public GameObject chicken,emu,wine,IceCream,Sushi,Egg,drink1,drink2,drink3,humbuger,ebi,tomato,letas,cosmonaut;
	private Rigidbody chickenR,emuR,wineR,IceCreamR,SushiR,EggR,drink1R,drink2R,drink3R,humbugerR,ebiR,tomatoR,letasR,cosmonautR;

	bool flag = false;


	void Start () {

		leftMass= 0;
		centerMass = 0;
		rightMass = 0;
		Score = 0;

		_ridit ();
		_gravityOFF ();
		afterburner.SetActive (false);
	}

	void Update () {

		_time(); //時間管理
		timerText.text = "Time"　+ useTime.ToString ();　//時間表示

		if (useTime <= 0) {
			timerText.text = "TIME UP";
		}
		if(useTime <= -3){
			timerText.text = "LAUNCH";
			_gravityON ();
			afterburner.SetActive (true);
		}
		if (useTime < -10 && !flag) {
			flag = true;
			if (rightMass >= leftMass + 10) {
				pointText.text = "右に墜落";
				_right ();
			}else if(rightMass + 10 <= leftMass){
				pointText.text = "左に墜落";
				_left ();
			}else{
				pointText.text = "SCORE " + Score.ToString();
				_center ();
			}
		}
	}

	void _time(){
		totalTime -= Time.deltaTime;
		useTime = (int)totalTime;
	}

	public void _right(){
		SceneManager.LoadScene("right");
	}

	public void _center(){
		SceneManager.LoadScene("center");
	}

	public void _left(){
		SceneManager.LoadScene("left");
	}

	void _ridit(){
		chickenR = chicken.GetComponent<Rigidbody>();
		emuR = emu.GetComponent<Rigidbody>();
		wineR = wine.GetComponent<Rigidbody>();
		IceCreamR = IceCream.GetComponent<Rigidbody>();
		SushiR = Sushi.GetComponent<Rigidbody>();
		EggR = Egg.GetComponent<Rigidbody>();
		drink1R = drink1.GetComponent<Rigidbody>();
		drink2R = drink2.GetComponent<Rigidbody>();
		drink3R = drink3.GetComponent<Rigidbody>();
		humbugerR = humbuger.GetComponent<Rigidbody>();
		ebiR = ebi.GetComponent<Rigidbody>();
		tomatoR = tomato.GetComponent<Rigidbody>();
		letasR = letas.GetComponent<Rigidbody>();
		cosmonautR = cosmonaut.GetComponent<Rigidbody>();
	}

	void _gravityOFF(){
		chickenR.useGravity = false;
		emuR.useGravity = false;
		wineR.useGravity = false;
		IceCreamR.useGravity = false;
		SushiR.useGravity = false;
		EggR.useGravity = false;
		drink1R.useGravity = false;
		drink2R.useGravity = false;
		drink3R.useGravity = false;
		humbugerR.useGravity = false;
		ebiR.useGravity = false;
		tomatoR.useGravity = false;
		letasR.useGravity = false;
		cosmonautR.useGravity = false;
	}

	void _gravityON(){
		chickenR.useGravity = true;
		emuR.useGravity = true;
		wineR.useGravity = true;
		IceCreamR.useGravity = true;
		SushiR.useGravity = true;
		EggR.useGravity = true;
		drink1R.useGravity = true;
		drink2R.useGravity = true;
		drink3R.useGravity = true;
		humbugerR.useGravity = true;
		ebiR.useGravity = true;
		tomatoR.useGravity = true;
		letasR.useGravity = true;
		cosmonautR.useGravity = true;
	}
}
