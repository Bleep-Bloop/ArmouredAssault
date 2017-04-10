using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabbedShopUI : MonoBehaviour {




	public GameObject pane1;
	//public GameObject pane2;
	///public GameObject pane3;
	//public GameObject pane4;
	//public GameObject pane5;
	//public GameObject pane6;


	void Awake()
	{
		pane1 = GameObject.FindGameObjectWithTag ("FirstPane");
	//	pane2 = GameObject.FindGameObjectWithTag ("SecondPane");
	//	pane3 = GameObject.FindGameObjectWithTag ("ThirdPane");
	//	pane4 = GameObject.FindGameObjectWithTag ("FourthPane");
	//	pane5 = GameObject.FindGameObjectWithTag ("FifthPane");
		//pane6 = GameObject.FindGameObjectWithTag ("SixthPane");

	}

	// Use this for initialization
	void Start () {




		//panes must be active at start of script but than deactivate them
		//deactivateAllPanes();
		//pane2.gameObject.SetActive (false);
		//pane3.gameObject.SetActive (false);
		//pane4.gameObject.SetActive (false);
		//pane5.gameObject.SetActive (false);
		//pane6.gameObject.SetActive (false);

		deactivateAllPanes ();

	}
	
	// Update is called once per frame
	void Update () {

		//deactivateAllPanes ();

	}


	public void deactivateAllPanes()
	{
		//Except the first panel
		pane1.gameObject.SetActive (false);
	//	pane2.gameObject.SetActive (false);
		//pane3.gameObject.SetActive (false);
		//pane4.gameObject.SetActive (false);
		//pane5.gameObject.SetActive (false);
		//pane6.gameObject.SetActive (false);

	}

	//function to show tab 1 (Default Shown)
	public void showPane1()
	{
		Debug.Log ("Showing Pane 1");

		//Show Pane
		pane1.gameObject.SetActive (true);

		//Hide others
		//pane2.gameObject.SetActive (false);
		//pane3.gameObject.SetActive (false);
		//pane4.gameObject.SetActive (false);
		//pane5.gameObject.SetActive (false);
		//pane6.gameObject.SetActive (false);

	}
	/*
	public void showPane2()
	{
		Debug.Log ("Showing Pane 2");

		pane2.gameObject.SetActive (true);

		pane1.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);

	}

	public void showPane3()
	{

		Debug.Log ("Showing Pane 3");

		pane3.gameObject.SetActive (true);

		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);

	}

	public void showPane4()
	{

		Debug.Log ("Showing Pane 4");

		pane4.gameObject.SetActive (true);

	
		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);
	}

	public void showPane5()
	{

		Debug.Log ("Showing Pane 5");

		pane5.gameObject.SetActive (true);

		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);


	}

	public void showPane6()
	{
		Debug.Log ("Showing Pane 6");

		pane6.gameObject.SetActive (true);
		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
	}


	//function to show tab 2
	//function to show tab 3
	//function to show tab 4

	public void printSTUFF()
	{
		Debug.Log ("Access is workin");
	}


	*/
}
