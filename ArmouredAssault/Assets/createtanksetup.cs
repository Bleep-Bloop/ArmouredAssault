using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createtanksetup : MonoBehaviour {

	public Mesh tankMesh;
	public GameObject testers;

	public GameObject[] availableTanks;

	// Use this for initialization
	void Start () {

		//GameObject testers = GameObject.CreatePrimitive         //reatePrimitive(PrimitiveType.Cube);
		//testers.AddComponent<Rigidbody>();



	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			print ("space key was pressed");


			Instantiate(availableTanks[1],transform);



		}


		if (Input.GetKeyDown ("x")) {
			Debug.Log ("Switching to second tank");
		}
	}
}
