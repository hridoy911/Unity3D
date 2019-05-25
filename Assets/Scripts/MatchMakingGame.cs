using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchMakingGame : MonoBehaviour {

	[System.Serializable]
	public struct Match
	{

		public Sprite correctImage;
		public Sprite correctAnsImage;
		public Button.ButtonClickedEvent OnCorrectCall;

		public Sprite[] wrongAnswers;
		public Button.ButtonClickedEvent OnWrongCall;
	}

	public Match[] matchOptions;
	public Button[] optionButton; 

	// Use this for initialization
	void Start () {
		
		mInitializeMatchMakingGame (0);
		//SceneManager.LoadScene ("mqs1");
	}

	private void mInitializeMatchMakingGame(int mMatchOptionIndex){


		int mAnswerButtonIndex = Random.Range (0, optionButton.Length);
		for (int index = 0; index < optionButton.Length; index++) {
		
			if (mAnswerButtonIndex == index) {
			
				optionButton [index].image.sprite = matchOptions [mMatchOptionIndex].correctImage;
				optionButton [index].onClick = matchOptions [mMatchOptionIndex].OnCorrectCall;


			} else {
			
				int mNumberOfWrongAnswer = matchOptions [mMatchOptionIndex].wrongAnswers.Length;
				optionButton [index].image.sprite = matchOptions [mMatchOptionIndex].wrongAnswers[Random.Range(0,mNumberOfWrongAnswer)];
				optionButton [index].onClick = matchOptions [mMatchOptionIndex].OnWrongCall;
			}
		}
	}

}
