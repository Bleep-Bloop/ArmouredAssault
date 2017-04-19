using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenShop : MonoBehaviour {

	public GameManager gameManager;

	// Use this for initialization
	void Start () {
	
		gameManager = GameManager.FindObjectOfType<GameManager> ();

	}
	
	// Update is called once per frame
	void Update () {


	}

	public void OpenShopScene()
	{

		Debug.Log ("Opening Shop");
		//Load GamePlayLoopLevel
		gameManager.destroyPropTank();
		SceneManager.LoadScene ("Shop");

		//gameManager.clearCount ();

	}

}
