using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTrigger : MonoBehaviour {


	public TankController player;  // Reference to player's self              // Reference to the player's position.

	// Use this for initialization
	void Start () {
	
		player = FindObjectOfType<TankController> ();


	}
	
	// Update is called once per frame
	void Update () {



	}

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player") {

			player.Death ();

		}

	}

}
