using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public int waveSize; // How many enemies you must kill before spawning more
	public int enemiesLeft; // Enemies left untill you hit respawn

	public Transform enemyPrefab; // Enemies to spawn

	public Transform playerTank;

	//public GameObject playerSpawn;
	public Transform playerSpawn;

	public int score; // Players score
	public int count; // Count for wave/enemies

	public Text scoreText; // For Text area for score

	public string currentEquippedTank;


	public void Awake () {

		//Carry GameManager over load screens
		//DontDestroyOnLoad (transform.gameObject);
		DontDestroyOnLoad (this);

		//Singletons beware (makes sure there is only one)
		if (FindObjectsOfType(GetType()).Length > 1)
		{
			Destroy(gameObject);
		}

		//done in onlevelloaded
		//playerSpawn = GameObject.FindGameObjectWithTag ("playerSpawnPoint").transform;



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





	void OnEnable()
	{
		//Tell our 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
		SceneManager.sceneLoaded += OnLevelFinishedLoading;
	}  //End OnEnable()

	void OnDisable()
	{
		//Tell our 'OnLevelFinishedLoading' function to stop listening for a scene change as soon as this script is disabled. Remember to always have an unsubscription for every delegate you subscribe to!
		SceneManager.sceneLoaded -= OnLevelFinishedLoading;
	}  //End OnEnable()

	void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
	{
		Debug.Log("Level Loaded");
		Debug.Log(scene.name);
		//Debug.Log(mode);

		//Regrab playerSpawnPoint
		playerSpawn = GameObject.FindGameObjectWithTag ("playerSpawnPoint").transform;

		Debug.Log ("New Spawnpoint Found");


		if (currentEquippedTank == "Player1") {


		}
		if (currentEquippedTank == "Player2") {


		}
		if (currentEquippedTank == "Player3") {


		}
		if (currentEquippedTank == "Player4") {


		}



		//come back here
		//playerTank = GameObject.FindGameObjectWithTag ("Player").transform;

		//spawn player 
		spawnPlayer();

		//might have to have all of them in the scene but deactivated or something 



		Debug.Log ("Player Spawned");

	}  //End OnEnable()







	public void spawnPlayer()
	{
		//Get Currently Equipped player
		//spawn on playerSpawn
		//might have to reload health 


		Debug.Log ("Spawning");
		//Instantiate(enemyPrefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
		//This WORKS!!!  Instantiate(enemyPrefab, playerSpawn.transform);
		//Instantiate(playerTank, playerSpawn.transform);


	}


	//make sure prefabs transforms are set to 0 0 0 than spawn just like spawnPlayer
	public void spawnEnemies() 
	{


	}



	public void whichTank()
	{
		//make puublic variable string currently equpped tank

		//Have 4 different tanks with each a different tag (player1, player2, player3, player4,

		//In the equipment ui script have an assign equpped tank tag to public string currentlyEquppedTank

		//Instantiate( currentlyEquppedTank, playerSppawn.transform); 	





	}


	//Call these in the equip screen when clicked
	public void equipTank1()
	{
		currentEquippedTank = "Player1";
		Debug.Log ("Tank 1 Equipped");
	}
	public void equipTank2()
	{
		currentEquippedTank = "Player2";
	}
	public void equipTank3()
	{
		currentEquippedTank = "Player3";
	}
	public void equipTank4()
	{
		currentEquippedTank = "Player4";
	}

} //End GameManager
