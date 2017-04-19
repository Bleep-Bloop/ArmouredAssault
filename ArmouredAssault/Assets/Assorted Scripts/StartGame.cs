using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public GameManager gameManager;

	// Use this for initialization
	void Start () {

		gameManager = GameManager.FindObjectOfType<GameManager> ();

	} //End Start()

	public void loadLevel()
	{
		//Load GamePlayLoopLevel
		SceneManager.LoadScene ("GameplayLoopLevel");

		gameManager.clearCount ();

	} //End loadLevel()

} //End StartGame
