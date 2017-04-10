using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class print : MonoBehaviour {


	public TabbedShopUI shopUI;

	// Use this for initialization
	void Start () {

		Debug.Log ("Level Loaded");
		shopUI = FindObjectOfType<TabbedShopUI> ();



	}
	
	// Update is called once per frame
	void Update () {
		shopUI.deactivateAllPanes ();
	}
}
