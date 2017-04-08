using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int waveSize; // How many enemies you must kill before spawning more
	public int enemiesLeft; // Enemies left untill you hit respawn

	public Transform enemyPrefab; // Enemies to spawn

	public int score; // Players score
	public int count; // Count for wave/enemies

	public Text scoreText; // For Text area for score

	public void Awake () {

		//Carry GameManager over load screens
		//DontDestroyOnLoad (transform.gameObject);
		DontDestroyOnLoad (this);

		//Singletons beware (makes sure there is only one)
		if (FindObjectsOfType(GetType()).Length > 1)
		{
			Destroy(gameObject);
		}


		// Reference to Canvas Text Component for holding score
		scoreText = GetComponentInChildren<Text> ();


		//Setting waveSize to 2 enemies (before spawning more
		waveSize = 2;
	
	} //End Awake()


	// Use this for initialization
	void Start () {
		
	} //End Start()


	// Update is called once per frame
	void Update () {

		//Change GameManager ScoreTextArea to Currrent Score
		scoreText.text = score.ToString();

		// If you have killed required amount of enemies
		if (count == waveSize) {

			// Spawn four more enemies (!*!*!*!*change 4 to variable with number of how much to spawn*!*!*!*!)
			for (int i = 0; i < 4; i++)
			{
				//Spawn Enemy (!*!*!*!* Change Spawn Locations *!*!*!*!)
				Instantiate(enemyPrefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
			}

			//reset count
			count = 0;

		}
			
	} //End Update ()


	public void addScore(int incomingScore)
	{
		score = score + incomingScore;
	} //End addScore()

	public void addCount()
	{
		count = count + 1;
	} //End addCount()

	public void clearCount()
	{
		count = 0;
	}

} //End GameManager
