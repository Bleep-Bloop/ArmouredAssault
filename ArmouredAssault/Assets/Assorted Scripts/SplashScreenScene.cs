using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenScene : MonoBehaviour {

	public GameObject splashScreen;

	void Awake()
	{

		splashScreen = GameObject.FindGameObjectWithTag ("SplashScreen");

	}

	// Use this for initialization
	void Start () {

		StartCoroutine (splashWaiting ());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator splashWaiting()
	{



		yield return new WaitForSeconds (5);

		//create GameManager after the timer done
		splashScreen.SetActive(false);

		SceneManager.LoadScene ("MainMenuScene");

	}



}
