﻿using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
	public Transform player;               // Reference to the player's position.
	//PlayerHealth playerHealth;      // Reference to the player's health.
	//EnemyHealth enemyHealth;        // Reference to this enemy's health.
	public NavMeshAgent nav;               // Reference to the nav mesh agent.
	public GameObject triggerZone;
	public Rigidbody enemyShell;  // Item that is fired from the tank's cannon
	public Transform FireTransform;  //  Empty GameObject Transform to spawn shells for firing
	public bool playerInSight = false; // Triggerbox to spot enemy (change to raycast)
	public EnemyAI enemy;  // Enemy reference to itself

	public bool isDead = false;  //Pretty sure this can be deleted

	void Awake ()
	{
		// Set up the references.

		//Find Player

		//	playerHealth = player.GetComponent <PlayerHealth> ();
		//enemyHealth = GetComponent <EnemyHealth> ();

		// Get own NavMeshAgent
		nav = GetComponent <NavMeshAgent> ();

		// Get Shells to fire
		enemyShell = GameObject.FindGameObjectWithTag ("Rocket").GetComponent<Rigidbody> ();

		// Get Trigger Zone to find enemy
		triggerZone = GameObject.FindGameObjectWithTag ("EnemySight");

		// Enemy gets itself
		enemy = this; 

	} //End Awake()


	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update ()
	{
		// If the enemy and the player have health left...
		//if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
		//{
			// ... set the destination of the nav mesh agent to the player.
			nav.SetDestination (player.position);
		//}
		// Otherwise...
		//else
		//{
			// ... disable the nav mesh agent.
		//	nav.enabled = false;
		//}

	} //End Update()


	void OnTriggerEnter(Collider player)
	{
		playerInSight = true;
		Debug.Log ("Firing at player");
		fire ();
	} //End OnTriggerEnter



	public void fire()
	{
		Debug.Log ("Firing");

		// Set the fired flag so only Fire is only called once.
	

		// Create an instance of the shell and store a reference to it's rigidbody.
		Rigidbody shellInstance =
			Instantiate (enemyShell, FireTransform.position, FireTransform.rotation) as Rigidbody;

		// Set the shell's velocity to the launch force in the fire position's forward direction.
		shellInstance.velocity = 30 * FireTransform.forward;


		// Change the clip to the firing clip and play it.
		//m_ShootingAudio.clip = m_FireClip;
		//m_ShootingAudio.Play ();

		// Reset the launch force.  This is a precaution in case of missing button events.

		Debug.Log ("Fired");

	} //End fire()


	public void kill()
	{

		//Destroy gameObject
		Destroy (this.gameObject);

		//Spawn seperate parts of tank with momentum to explode them out but make them triggers so they fall through ground than delete them

		//Add particle effect and maybe spawn parts with outwards direction momentum
	
	} //End kill()


} //End EnemyAI