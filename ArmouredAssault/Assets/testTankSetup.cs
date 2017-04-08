using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testTankSetup : MonoBehaviour {

	public MeshFilter mFilter;
	public MeshFilter[] changeToThis;//[] changeToThis;

	//Create an array of available tank meshes

	// Use this for initialization
	void Start () {
	
		mFilter = GetComponent<MeshFilter>();


	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.Space)) {
			//mFilter.mesh = mMeshes [Random.Range (0, mMeshes.Length)];
			Debug.Log("Changing Mesh");
			//mFilter.// = changeToThis [0]; 
			mFilter = changeToThis[0];
		
		}


	}
}
