using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour {


	public GameObject testPane;
	public Button button;

	public Color color;

	// Use this for initialization
	void Start () {

		testPane = GameObject.FindGameObjectWithTag ("testPanel");
		//button = GameObject.FindGameObjectWithTag ("testButton");

		color = new Color (0.2f, 0.3f, 0.4f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {





	}


	public void hidePanel()
	{

		testPane.gameObject.SetActive (false);

	}



}
