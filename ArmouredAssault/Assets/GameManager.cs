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

	public GameObject equippedTank;

	public GameObject playerCamera;

	//public GameObject mainMenuButton;


	//public GameObject playerSpawn;
	//public Transform playerSpawn;

	public int score; // Players score
	public int count; // Count for wave/enemies

	public Text scoreText; // For Text area for score

	public GameObject currentEquippedTank;

	public GameObject defaultTanks;

	public GameObject canvas1;
	public GameObject canvas2;

	public Scene currentScene;
	public string currentSceneName;


	//All tanks available in game
	//make array later
	public GameObject tank1;
	public GameObject tank2;
	public GameObject tank3;

	public TankController playerTankController;
	public TankShooting playerTankShooting;

	public bool canUseTank1 = true;
	public bool canUseTank2 = false;
	public bool canUseTank3 = false;


	//make a function getPlayerSpawn and call on level load every time scene is loaded
	public GameObject playerSpawn;



	public bool button11 = false;	public bool button21 = false;	public bool button31 = false;
	public bool button12 = false;	public bool button22 = false;	public bool button32 = false;
	public bool button13 = false;	public bool button23 = false;	public bool button33 = false;

	public bool button41 = false;	public bool button51 = false;	public bool button61 = false;
	public bool button42 = false;	public bool button52 = false;	public bool button62 = false;
	public bool button43 = false;	public bool button53 = false;	public bool button63 = false;



	public void Awake () {

		//Carry GameManager over load screens
		//DontDestroyOnLoad (transform.gameObject);
		DontDestroyOnLoad (this);

		addScore (1000);

		//mainMenuButton = GameObject.FindGameObjectWithTag ("MainMenuButton");
	

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

	public void subtractScore(int incomingScore)
	{
		score = score - incomingScore;
	}

	public void addCount()
	{
		count = count + 1;
	} //End addCount()

	public void clearCount()
	{
		count = 0;
	}















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

	void OnLevelWasLoaded()
	{
		Debug.Log ("level loaded");
		getSpawnPoint ();

		//test instantiate tank2
		Instantiate(defaultTanks, playerSpawn.transform.position, playerSpawn.transform.rotation);
		Debug.Log ("Tank Spawned");


		playerTankController = FindObjectOfType<TankController>();
		playerTankShooting = FindObjectOfType<TankShooting>();
		playerTankController.enabled = false;
		playerTankShooting.enabled = false;

		currentScene = SceneManager.GetActiveScene ();
		currentSceneName = currentScene.name;

		canvas1 = GameObject.FindGameObjectWithTag ("hideCanvas");

		playerCamera = GameObject.FindGameObjectWithTag ("playerCamera");

		if (currentSceneName == "MainMenuScene") {

			canvas1.SetActive (false);
			playerCamera.SetActive (false);
			//mainMenuButton.SetActive (false);
		}

		if (currentSceneName == "GameplayLoopLevel") {

			playerTankController.enabled = true;
			playerTankShooting.enabled = true;
			playerCamera.SetActive (true);
		}

		if (currentSceneName == "Shop") {

			canvas1.SetActive (false);
			playerCamera.SetActive (false);
			//mainMenuButton.SetActive (true);
		}


		//if (GameObject.FindGameObjectsWithTag ("hideCanvas").Length > 1) {

			//Debug.Log ("2MANY!!!!!!!!!");
		//}



	}

	public void getSpawnPoint()
	{

		Debug.Log ("GOT SPAWN POINT");
		playerSpawn = GameObject.FindGameObjectWithTag ("playerSpawnPoint");

	}


	public void whichTank()
	{
		//make puublic variable string currently equpped tank

		//Have 4 different tanks with each a different tag (player1, player2, player3, player4,

		//In the equipment ui script have an assign equpped tank tag to public string currentlyEquppedTank

		//Instantiate( currentlyEquppedTank, playerSppawn.transform); 	




	}




	public void hurt()
	{
		playerTankController.currentHealth = playerTankController.currentHealth - 1;
		Debug.Log ("Ouch");
	}




	public void hideAllTanks()
	{





	}


	public void button11status(){

		button11 = true;

		Debug.Log ("working");
	}

	public void button12status(){
		button12 = true;
	}

	public void button13status(){
		button13 = true;
	
	}


	public void button21status(){
		button21 = true;
	}
	public void button22status(){
		button22 = true;
	}
	public void button23status(){
		button23 = true;
	}



	public void button31status(){
		button31 = true;
	
	}
	public void button32status(){
	
		button32 = true;
	
	}
	public void button33status(){
		button33 = true;
	}


	public void button41status(){
		button41 = true;
	}
	public void button42status(){
		button42 = true;
	}
	public void button43status(){
		button43 = true;
	}


	public void button51status(){
		button51 = true;
	}
	public void button52status(){
		button52 = true;
	}
	public void button53status(){
		button53 = true;
		}

	public void button61status(){
		button61 = true;
	}
	public void button62status(){
		button62 = true;
	}
	public void button63status(){
		button63 = true;
	}


	public void equipTank1()
	{
		if (canUseTank1 == true) {
			Debug.Log ("Equipping Tank1");
			defaultTanks = tank1;
		} else {
			Debug.Log ("Buy First");
		}
	}

	public void equipTank2()
	{
		if (canUseTank2 == true) {
			defaultTanks = tank2;
		} else {
			Debug.Log ("Buy First");
		}
	}

	public void equipTank3()
	{
		if (canUseTank3 == true) {
			Debug.Log ("Equipping Tank3");
			defaultTanks = tank3;
		} else {
			Debug.Log ("Buy First");
		}
	}

	public void destroyPropTank()
	{
		//

	}

} //End GameManager
