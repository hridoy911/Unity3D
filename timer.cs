using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {


	public Text timerText;
	private float startTime;
	private bool finished = false;
	
	// Update is called once per frame
	void Update () {

		if (finished)
			return;

		float t = Time.deltaTime - startTime;
		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f2");

		timerText.text = "Time:" + minutes + ";" + seconds;
		
	}

	public void Finished() {

		finished = true;
	}
}
