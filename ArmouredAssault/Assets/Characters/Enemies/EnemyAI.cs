using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
	public Transform player;               // Reference to the player's position.
	//PlayerHealth playerHealth;      // Reference to the player's health.
	//EnemyHealth enemyHealth;        // Reference to this enemy's health.
	public NavMeshAgent nav;               // Reference to the nav mesh agent.

	public GameObject triggerZone;

	public Rigidbody enemyShell;

	public Transform FireTransform;

	public bool playerInSight = false;

	public bool isDead = false;

	public EnemyAI enemy;

	void Awake ()
	{
		// Set up the references.
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	//	playerHealth = player.GetComponent <PlayerHealth> ();
		//enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <NavMeshAgent> ();

		enemyShell = GameObject.FindGameObjectWithTag ("Rocket").GetComponent<Rigidbody> ();

		triggerZone = GameObject.FindGameObjectWithTag ("EnemySight");

		enemy = this;

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




	} 


	void OnTriggerEnter(Collider player)
	{
		playerInSight = true;
		Debug.Log ("Firing at player");
		fire ();
	}



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

	}


	public void kill()
	{

		Destroy (this.gameObject);
		Debug.Log ("Killed hiim dead");
		//Add particle effect and maybe spawn parts with outwards direction momentum
	
	}


}