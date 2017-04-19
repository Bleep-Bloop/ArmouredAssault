using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TabbedShopUI : MonoBehaviour {




	public GameObject pane1;
	public GameObject pane2;
	public GameObject pane3;
	public GameObject pane4;
	public GameObject pane5;
	public GameObject pane6;

	public GameObject[] pane1buys;
	public GameObject[] pane2buys;
	public GameObject[] pane3buys;
	public GameObject[] pane4buys;
	public GameObject[] pane5buys;
	public GameObject[] pane6buys;

	public Button purchaseTank1Button;
	public GameObject test;
	public GameManager gameManager;



	void Awake()
	{

		//Get GameObjects
		pane1 = GameObject.FindGameObjectWithTag ("FirstPane");
		pane2 = GameObject.FindGameObjectWithTag ("SecondPane");
		pane3 = GameObject.FindGameObjectWithTag ("ThirdPane");
		pane4 = GameObject.FindGameObjectWithTag ("FourthPane");
		pane5 = GameObject.FindGameObjectWithTag ("FifthPane");
		pane6 = GameObject.FindGameObjectWithTag ("SixthPane");

		pane1buys = GameObject.FindGameObjectsWithTag ("panel1buys");
		pane2buys = GameObject.FindGameObjectsWithTag ("panel2buys");
		pane3buys = GameObject.FindGameObjectsWithTag ("panel3buys");
		pane4buys = GameObject.FindGameObjectsWithTag ("panel4buys");
		pane5buys = GameObject.FindGameObjectsWithTag ("panel5buys");
		pane6buys = GameObject.FindGameObjectsWithTag ("panel6buys");

		//purchaseTank1Button = GameObject.FindGameObjectWithTag ("purchaseTank1Button");

		//purchaseTank1Button = GameObject.FindGameObjectWithTag ("purchaseTank1Button").GetComponent<Button> ();  // ("Play").GetComponent<Button>();


	}  //End Awake()

	// Use this for initialization
	void Start () {

		gameManager = GameManager.FindObjectOfType<GameManager> ();
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


		//Get a loop when not so tired
		pane1buys[0].gameObject.SetActive(false);
		pane2buys[0].gameObject.SetActive(false);
		pane3buys[0].gameObject.SetActive(false);
		pane4buys[0].gameObject.SetActive(false);
		pane5buys[0].gameObject.SetActive(false);
		pane6buys[0].gameObject.SetActive(false);

		pane1buys[1].gameObject.SetActive(false);
		pane2buys[1].gameObject.SetActive(false);
		pane3buys[1].gameObject.SetActive(false);
		pane4buys[1].gameObject.SetActive(false);
		pane5buys[1].gameObject.SetActive(false);
		pane6buys[1].gameObject.SetActive(false);

		pane1buys[2].gameObject.SetActive(false);
		pane2buys[2].gameObject.SetActive(false);
		pane3buys[2].gameObject.SetActive(false);
		pane4buys[2].gameObject.SetActive(false);
		pane5buys[2].gameObject.SetActive(false);
		pane6buys[2].gameObject.SetActive(false);


	//	purchaseTank1Button.gameObject.SetActive (false);
	
	}  //End deactivateAllPanes()
		

	public void showPane1()
	{
		Debug.Log ("Showing Pane 1");

		//Show Pane
		pane1.gameObject.SetActive (true);
		pane1buys[0].gameObject.SetActive(true);
		pane1buys[1].gameObject.SetActive(true);
		pane1buys[2].gameObject.SetActive(true);
		//purchaseTank1Button.gameObject.SetActive (true);

		//Hide others
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);

		hidePane6buys ();
		hidePane5buys ();
		hidePane4buys ();
		hidePane3buys ();
		hidePane2buys ();

	}  //End showPane1

	public void showPane2()
	{
		Debug.Log ("Showing Pane 2");

		pane2.gameObject.SetActive (true);
		pane2buys[0].gameObject.SetActive(true);
		pane2buys[1].gameObject.SetActive(true);
		pane2buys[2].gameObject.SetActive(true);


		pane1.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);
		//purchaseTank1Button.gameObject.SetActive (false);

		hidePane6buys ();
		hidePane5buys ();
		hidePane4buys ();
		hidePane3buys ();
		hidePane1buys ();


	}  //End showPane2()

	public void showPane3()
	{

		Debug.Log ("Showing Pane 3");

		pane3.gameObject.SetActive (true);
		pane3buys[0].gameObject.SetActive(true);
		pane3buys[1].gameObject.SetActive(true);
		pane3buys[2].gameObject.SetActive(true);

		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);
		//purchaseTank1Button.gameObject.SetActive (false);
		hidePane6buys ();
		hidePane5buys ();
		hidePane4buys ();
		hidePane1buys ();
		hidePane2buys ();


	}  //End showPane3()

	public void showPane4()
	{

		Debug.Log ("Showing Pane 4");

		pane4.gameObject.SetActive (true);
		pane4buys[0].gameObject.SetActive(true);
		pane4buys[1].gameObject.SetActive(true);
		pane4buys[2].gameObject.SetActive(true);

	
		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);

		hidePane6buys ();
		hidePane5buys ();
		hidePane1buys ();
		hidePane3buys ();
		hidePane2buys ();



		//purchaseTank1Button.gameObject.SetActive (false);
	}  //End showPane4

	public void showPane5()
	{

		Debug.Log ("Showing Pane 5");

		pane5.gameObject.SetActive (true);
		pane5buys[0].gameObject.SetActive(true);
		pane5buys[1].gameObject.SetActive(true);
		pane5buys[2].gameObject.SetActive(true);

		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane6.gameObject.SetActive (false);
		//purchaseTank1Button.gameObject.SetActive (false);

		hidePane6buys ();
		hidePane1buys ();
		hidePane4buys ();
		hidePane3buys ();
		hidePane2buys ();


	}  //End showPane5()

	public void showPane6()
	{
		Debug.Log ("Showing Pane 6");

		pane6.gameObject.SetActive (true);
		pane6buys[0].gameObject.SetActive(true);
		pane6buys[1].gameObject.SetActive(true);
		pane6buys[2].gameObject.SetActive(true);

		pane1.gameObject.SetActive (false);
		pane2.gameObject.SetActive (false);
		pane3.gameObject.SetActive (false);
		pane4.gameObject.SetActive (false);
		pane5.gameObject.SetActive (false);

		hidePane1buys ();
		hidePane5buys ();
		hidePane4buys ();
		hidePane3buys ();
		hidePane2buys ();

		//purchaseTank1Button.gameObject.SetActive (false);
	}  //End showPane6()


	public void hidePane1buys()
	{
		pane1buys[0].gameObject.SetActive(false);
		pane1buys[1].gameObject.SetActive(false);
		pane1buys[2].gameObject.SetActive(false);
	}

	public void hidePane2buys()
	{
		pane2buys[0].gameObject.SetActive(false);
		pane2buys[1].gameObject.SetActive(false);
		pane2buys[2].gameObject.SetActive(false);
	}

	public void hidePane3buys()
	{
		pane3buys[0].gameObject.SetActive(false);
		pane3buys[1].gameObject.SetActive(false);
		pane3buys[2].gameObject.SetActive(false);
	}

	public void hidePane4buys()
	{
		pane4buys[0].gameObject.SetActive(false);
		pane4buys[1].gameObject.SetActive(false);
		pane4buys[2].gameObject.SetActive(false);
	}

	public void hidePane5buys()
	{
		pane5buys[0].gameObject.SetActive(false);
		pane5buys[1].gameObject.SetActive(false);
		pane5buys[2].gameObject.SetActive(false);
	}

	public void hidePane6buys()
	{
		pane6buys[0].gameObject.SetActive(false);
		pane6buys[1].gameObject.SetActive(false);
		pane6buys[2].gameObject.SetActive(false);
	}



	public void printingthisstuff()
	{
		Debug.Log ("YOU FIXED THE BUTTPM");
	}




}
