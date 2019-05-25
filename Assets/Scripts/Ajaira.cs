using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ajaira : MonoBehaviour {

	public Text gameTimeDisplayText;

	// Use this for initialization
	void Start () {

		gameTimeDisplayText.text = "Last Score: " + GameManager.GameTime.ToString();
	}

}
