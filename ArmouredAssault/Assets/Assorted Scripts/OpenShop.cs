using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenShop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void OpenShopScene()
	{

		Debug.Log ("Opening Shop");
		//Load GamePlayLoopLevel
		SceneManager.LoadScene ("Shop");

		//gameManager.clearCount ();

	}

}
