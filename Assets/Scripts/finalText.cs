using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalText : MonoBehaviour {

	public float m_EstimatedTime;
	public float m_PlayerTime;
	public float m_performance;
	public Text mText;


	// Use this for initialization
	void Start () {
		m_EstimatedTime = 5.0f;
		m_PlayerTime = PlayerPrefs.GetFloat ("Time");
		Debug.Log ("Player Time : " + m_PlayerTime);
		Debug.Log ("Estimated Time : " + m_EstimatedTime);
		m_performance = (m_EstimatedTime / m_PlayerTime) * 100.0f;
		Debug.Log ("Performance : " + m_performance);

		if (m_performance < m_EstimatedTime) {
			mText.text = "Excellent";
			Debug.Log ("Excellent");
		} else {
			
			if (m_performance >= 75) {
				mText.text = "Great!";
				Debug.Log ("Great!");
			} else if (m_performance >= 50) {
				mText.text = "Good";
				Debug.Log ("Good");
			} else if (m_performance >= 25) {
				mText.text = "Poor";
				Debug.Log ("Poor");
			} else {
				mText.text = "Bad";
				Debug.Log ("Bad");
			}
		}
	}
}
