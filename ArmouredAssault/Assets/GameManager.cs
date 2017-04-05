using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int score;

	public Text scoreText;

	public string blank ;

	public void Awake () {

		//Will carry over loads
		DontDestroyOnLoad (transform.gameObject);
		scoreText = GetComponentInChildren<Text> ();
		blank = " ";
	}


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		scoreText.text = blank;

		//Change score to whatever it is
		scoreText.text = score.ToString();


	}


	public void addScore(int incomingScore)
	{
		score = score + incomingScore;
	}


}
