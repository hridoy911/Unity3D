using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SC4 : MonoBehaviour {

	public int score = 0;
	public Text maText;
	public static float GameTime;
	public float Ttime;
	public GameObject timerRefeference;

	public void UpdateScore(){

		GameTime = timerRefeference.GetComponent<timer> ().timerCounter;
		score++;

		// 1 < 1
		if (score == 1) {

			maText.text = "Score:" + score;
			PlayerPrefs.SetFloat ("Time_dl", GameTime);
			Ttime = PlayerPrefs.GetFloat ("Time_dl");
			Debug.Log (Ttime);
			SceneManager.LoadScene ("mqs5");
		}

		Debug.Log ("Done");
	}
}