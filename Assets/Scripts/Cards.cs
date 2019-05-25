﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Cards : MonoBehaviour {

	public static bool Flags = false;

	[SerializeField]
	private int _state;
	[SerializeField]
	private int _cardValue;
	[SerializeField]
	private bool _initialized = false;

	private Sprite _cardBack;
	private Sprite _cardFace;

	private GameObject _manager;

	void Start() {

		_state = 1;
		_manager = GameObject.FindGameObjectsWithTag ("Manager")[0];

	}


	public void setupGraphics() {
		_cardBack = _manager.GetComponent<GameManager> ().getCardBack ();
		_cardFace = _manager.GetComponent<GameManager> ().getCardFace (_cardValue);

		flipCard ();
	}

	public void flipCard() {


		if (_state == 0)
			_state = 1;
		else if (_state == 1)
			_state = 0;


		if (_state == 0 && !Flags) {

			GetComponent<Image> ().sprite = _cardBack;
		} else if (_state == 1 && !Flags) {

			GetComponent<Image> ().sprite = _cardFace;
		}
	}

	public int cardValue {

		get { return _cardValue; }
		set { _cardValue = value; }

	}

	public int state {

		get { return _state; }
		set { _state = value; }

	}
		
	public bool initialized {

		get { return _initialized; }
		set { _initialized = value; }

	}

	public void falseCheck() {

		StartCoroutine (pause());

	}

	IEnumerator pause(){

		yield return new WaitForSeconds (1);
		if (_state == 0)
			GetComponent<Image> ().sprite = _cardBack;
		else if(_state == 1)
			GetComponent<Image> ().sprite = _cardFace;
		Flags = false;
	}


}
