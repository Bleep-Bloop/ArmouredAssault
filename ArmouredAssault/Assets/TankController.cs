using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {

	public float speed = 5.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		goForward ();

	}


	public void goForward() 
	{

		transform.Translate (Vector3.forward * (speed) * Time.deltaTime);

	}


}
