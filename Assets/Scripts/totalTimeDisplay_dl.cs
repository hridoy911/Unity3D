using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalTimeDisplay_dl : MonoBehaviour {

	public Text gameTimeDisplayText;



	// Use this for initialization
	void Start () {

		gameTimeDisplayText.text = "Total time: " + PlayerPrefs.GetFloat("Time_dl");
	}

}


