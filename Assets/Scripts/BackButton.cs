using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

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
}