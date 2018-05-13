using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonScript : MonoBehaviour {

	public void RetryButton(){
		SceneManager.LoadScene("start");
	}

}
