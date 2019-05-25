using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SC1 : MonoBehaviour {

	public int score = 1;
	public Text maText;
	public static float GameTime;
	public float Ttime;
	public GameObject timerRefeference;

	public void UpdateScore(){

		GameTime = timerRefeference.GetComponent<timer> ().timerCounter;

		score++;

		// 1 < 1
		if (score == 2) {

			maText.text = "Score:" + score;
			Ttime = PlayerPrefs.GetFloat ("Time");
			Debug.Log (Ttime);
			PlayerPrefs.SetFloat ("Time", GameTime);
			Ttime = Ttime + PlayerPrefs.GetFloat ("Time");
			PlayerPrefs.SetFloat ("Time", Ttime);
			Debug.Log (Ttime);
			SceneManager.LoadScene ("mqs2");
		}

		Debug.Log ("Done");
	}
}
