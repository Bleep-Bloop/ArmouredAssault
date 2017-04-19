using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitbox : MonoBehaviour {

	public TankController player;  // Reference to player's self


	void Awake()
	{
		
	} //End Awake()


	// Use this for initialization
	void Start () {

		// Grab TankController as reference to player's self
		player = GetComponentInParent<TankController> ();

	} //End Start()
	
	// Update is called once per frame
	void Update () {

	} //End Update()


	public void OnTriggerEnter(Collider other)
	{
		//If GameObject entering TriggerZone is a rocket
		if (other.tag == "Rocket") {

			// Run TankController.Damage()
			player.Damage();
		
		}
	} //End OnTriggerEnter(Collider other)




} //End PlayerHitbox
