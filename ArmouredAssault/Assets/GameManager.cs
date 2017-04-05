using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int waveSize;
	public int enemiesLeft;

	public Transform enemyPrefab;

	public int score;
	public int count;

	public Text scoreText;

	public string blank ;

	public void Awake () {

		//Will carry over loads
		DontDestroyOnLoad (transform.gameObject);
		scoreText = GetComponentInChildren<Text> ();
		blank = " ";
		waveSize = 2;
	}


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		scoreText.text = blank;

		//Change score to whatever it is
		scoreText.text = score.ToString();


		if (count == waveSize) {
			Debug.Log ("Sending more enemies");



			for (int i = 0; i < 4; i++)
			{
				Debug.Log ("Spawning an enemy");
				Instantiate(enemyPrefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
			}

			//reset count
			count = 0;

		}


	}


	public void addScore(int incomingScore)
	{
		score = score + incomingScore;
	}

	public void addCount()
	{
		count = count + 1;
	}





}
