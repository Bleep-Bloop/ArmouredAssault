using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	} //End Start()

	public void loadLevel()
	{
		//Load GamePlayLoopLevel
		SceneManager.LoadScene ("GameplayLoopLevel");

	} //End loadLevel()

} //End StartGame
