using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {


	public Text timeText;
	public float duration;

	private float startTime;

	[HideInInspector]
	public float timerCounter;

	void Start(){

		startTime = Time.time;
	}

	// Update is called once per frame
	void Update () {

		timerCounter = Time.time - startTime;
		
		timeText.text = "Time : " +   timerCounter.ToString ();
	}

}