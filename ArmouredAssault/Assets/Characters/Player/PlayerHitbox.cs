using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitbox : MonoBehaviour {

	public TankController player;


	// Use this for initialization
	void Start () {

		player = GetComponentInParent<TankController> ();

	}
	
	// Update is called once per frame
	void Update () {


		
	}


	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Rocket") {
			player.Damage();
			//Debug.Log ("You killed me");
		}
	}




}
