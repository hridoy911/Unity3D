using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuBehave : MonoBehaviour {

    public void triggerMenuBehaviour(int i)
    {
        switch (i)
        {
            default:
            case (0):
                SceneManager.LoadScene("mqs4");
                break;
			case (1):
				SceneManager.LoadScene("mqs");
				break;
			case (2):
				SceneManager.LoadScene("memory_clr");
				break;
			case (3):
				SceneManager.LoadScene("memory");
				break;
			case (4):
				Application.Quit();
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
