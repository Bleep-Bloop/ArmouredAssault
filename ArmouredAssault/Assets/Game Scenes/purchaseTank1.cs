using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purchaseTank1 : MonoBehaviour {

	public GameManager gameManager; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void purchasingTank1(){
		// this object was clicked - do something
		Debug.Log("Purchasing Tank 1");

		gameManager = GameManager.FindObjectOfType<GameManager> ();

		gameManager.equipTank1 ();

	}


}
