using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabbedShopUI : MonoBehaviour {




	public GameObject pane1;
	public GameObject pane2;
	public GameObject pane3;
	public GameObject pane4;
	public GameObject pane5;
	public GameObject pane6;


	void Awake()
	{

		//Get GameObjects
		pane1 = GameObject.FindGameObjectWithTag ("FirstPane");
		pane2 = GameObject.FindGameObjectWithTag ("SecondPane");
		pane3 = GameObject.FindGameObjectWithTag ("ThirdPane");
		pane4 = GameObject.FindGameObjectWithTag ("FourthPane");
		pane5 = GameObject.FindGameObjectWithTag ("FifthPane");
		pane6 = GameObject.FindGameObjectWithTag ("SixthPane");

	}  //End Awake()

	// Use this for initialization
	void Start () {

		deactivateAllPanes ();
		showPane1 ();

	}  //End Start()
	
	// Update is called once per frame
	void Update () {



	}  //End Update()
		
	public void deactivateAllPanes()
	{
		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);
	
	}  //End deactivateAllPanes()
		

	public void showPane1()
	{
		Debug.Log ("Showing Pane 1");

		//Show Pane
		pane1.gameObject.SetActive (true);

		//Hide others
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);

	}  //End showPane1

	public void showPane2()
	{
		Debug.Log ("Showing Pane 2");

		pane2.gameObject.SetActive (true);

		pane1.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);

	}  //End showPane2()

	public void showPane3()
	{

		Debug.Log ("Showing Pane 3");

		pane3.gameObject.SetActive (true);

		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);

	}  //End showPane3()

	public void showPane4()
	{

		Debug.Log ("Showing Pane 4");

		pane4.gameObject.SetActive (true);

	
		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);
	}  //End showPane4

	public void showPane5()
	{

		Debug.Log ("Showing Pane 5");

		pane5.gameObject.SetActive (true);

		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);

	}  //End showPane5()

	public void showPane6()
	{
		Debug.Log ("Showing Pane 6");

		pane6.gameObject.SetActive (true);
		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
	}  //End showPane6()







}
