using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SC6 : MonoBehaviour {


	public int score = 2;
	public Text maText;
	public static float GameTime;
	public float Ttime;
	public GameObject timerRefeference;

	public void UpdateScore(){

		GameTime = timerRefeference.GetComponent<timer> ().timerCounter;

		score++;

		// 1 < 1
		if (score == 3) {

			maText.text = "Score:" + score;
			Ttime = PlayerPrefs.GetFloat ("Time_dl");
			Debug.Log (Ttime);
			PlayerPrefs.SetFloat ("Time_dl", GameTime);
			Ttime = Ttime + PlayerPrefs.GetFloat ("Time_dl");
			PlayerPrefs.SetFloat ("Time_dl", Ttime);
			Debug.Log (Ttime);
			SceneManager.LoadScene ("finishScene_dl");
		}

		Debug.Log ("Done");
	}

}
