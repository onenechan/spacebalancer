using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{

	public float totalTime;
	public static int useTime;
	public Text timerText, pointText;
	public GameObject afterburner;  //rocketの火

	public static int leftMass, centerMass, rightMass, Score;

	//荷物の宣言
	public GameObject chicken, emu, wine, IceCream, Sushi, Egg, drink1, drink2, drink3, humbuger, ebi, tomato, letas, cosmonaut;
	private Rigidbody chickenR, emuR, wineR, IceCreamR, SushiR, EggR, drink1R, drink2R, drink3R, humbugerR, ebiR, tomatoR, letasR, cosmonautR;

	bool flag = false;
	bool flag1 = false;
	public GameObject migi, hidari;

	void Start()
	{

		leftMass = 0;
		centerMass = 0;
		rightMass = 0;
		Score = 0;

		_ridit();
		_gravityOFF();
		afterburner.SetActive(false);

		migi = GameObject.Find("migi");
		//migi.GetComponent <DestroyObjectScript>().enabled = false;
		hidari = GameObject.Find("hidari");
		//hidari.GetComponent<DestroyObjectScript> ().enabled = false;

	}

	void Update()
	{

		_time(); //時間管理
		timerText.text = "Time" + useTime.ToString(); //時間表示

		if (useTime <= 0)
		{
			timerText.text = "TIME UP";
		}
		if (useTime <= -3)
		{
			timerText.text = "LAUNCH";
			_gravityON();
			afterburner.SetActive(true);
		}
		if (useTime <= 0 && !flag1)
		{
			//migi.GetComponent <DestroyObjectScript>().enabled = true;
			//hidari.GetComponent <DestroyObjectScript>().enabled = true;
			flag1 = true;
			migi.AddComponent<DestroyObjectScript>();
			hidari.AddComponent<DestroyObjectScript>();
		}
		if (useTime < -8 && !flag)
		{
			flag = true;
			if (rightMass >= leftMass + 10)
			{
				pointText.text = "右に墜落";
				_right();
			}
			else if (rightMass + 10 <= leftMass)
			{
				pointText.text = "左に墜落";
				_left();
			}
			else
			{
				pointText.text = "SCORE " + Score.ToString();
				_center();
			}
		}
	}

	void _time()
	{
		totalTime -= Time.deltaTime;
		useTime = (int)totalTime;
	}

	public void _right()
	{
		SceneManager.LoadScene("right");
	}

	public void _center()
	{
		SceneManager.LoadScene("center");
	}

	public void _left()
	{
		SceneManager.LoadScene("left");
	}

	void _ridit()
	{
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

	void _gravityOFF()
	{
		if (chickenR)
			chickenR.useGravity = false;
		if (emuR)
			emuR.useGravity = false;
		if (wineR)
			wineR.useGravity = false;
		if (IceCreamR)
			IceCreamR.useGravity = false;
		if (SushiR)
			SushiR.useGravity = false;
		if (EggR)
			EggR.useGravity = false;
		if (drink1R)
			drink1R.useGravity = false;
		if (drink2R)
			drink2R.useGravity = false;
		if (drink3R)
			drink3R.useGravity = false;
		if (humbugerR)
			humbugerR.useGravity = false;
		if (ebiR)
			ebiR.useGravity = false;
		if (tomatoR)
			tomatoR.useGravity = false;
		if (letasR)
			letasR.useGravity = false;
		if (cosmonautR)
			cosmonautR.useGravity = false;
	}

	void _gravityON()
	{
		if (chickenR)
			chickenR.useGravity = true;
		if (emuR)
			emuR.useGravity = true;
		if (wineR)
			wineR.useGravity = true;
		if (IceCreamR)
			IceCreamR.useGravity = true;
		if (SushiR)
			SushiR.useGravity = true;
		if (EggR)
			EggR.useGravity = true;
		if (drink1R)
			drink1R.useGravity = true;
		if (drink2R)
			drink2R.useGravity = true;
		if (drink3R)
			drink3R.useGravity = true;
		if (humbugerR)
			humbugerR.useGravity = true;
		if (ebiR)
			ebiR.useGravity = true;
		if (tomatoR)
			tomatoR.useGravity = true;
		if (letasR)
			letasR.useGravity = true;
		if (cosmonautR)
			cosmonautR.useGravity = true;
	}
}

