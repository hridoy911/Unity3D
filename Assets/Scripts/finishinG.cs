using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class finishinG : MonoBehaviour {




	public void triggerMenuBehaviour(int i)
	{
		switch (i)
		{
		default:
		case (0):
			SceneManager.LoadScene("menu");
			break;
		}

	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
