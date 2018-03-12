using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CommunicateWithGameManager : MonoBehaviour {

	public GameManager gameManager;
	public int playerScore;

	void OnLevelWasLoaded()
	{
		gameManager = GameManager.FindObjectOfType<GameManager> ();
	}

	// Use this for initialization
	void Start () {

		getScore ();

	}
	
	// Update is called once per frame
	void Update () {


	}

	public void getScore()
	{
		playerScore = gameManager.score;


	}

	public void subractScore(int cost)
	{
		gameManager.subtractScore (cost);
	}

	public void tank2bought()
	{
		if(gameManager.score >= 500)
		{
			gameManager.canUseTank2 = true;
			Debug.Log ("Bought tank 2");
			subractScore (500);
		}
		else {
			Debug.Log("not enough money");
		}
	}

	public void tank3bought()
	{
		if(gameManager.score >= 500)
		{
			gameManager.canUseTank3 = true;
			Debug.Log ("Bought tank 3");
			subractScore (500);
		}
		else {
			Debug.Log("notenough money");
		}
	}


	public void callEquipTank1()
	{
		gameManager.equipTank1 ();
	}

	public void callEquipTank2()
	{
		gameManager.equipTank2 ();
	}

	public void callEquipTank3()
	{
		gameManager.equipTank3 ();
	}


}
