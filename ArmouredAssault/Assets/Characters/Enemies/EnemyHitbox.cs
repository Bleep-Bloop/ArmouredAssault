using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHitbox : MonoBehaviour
{

	public GameManager gameManager;
	public Text scoreText;

	public EnemyAI enemy;

	// Use this for initialization
	void Start ()
	{
		//  Get the enemy tank you are a part of
		enemy = GetComponentInParent<EnemyAI> ();

		//  Get the GameManager for communication about score/enemies left
		gameManager = GameManager.FindObjectOfType<GameManager> ();

		//  Get the Text component to display score
		scoreText = gameManager.GetComponentInChildren<Text> ();

	}//End Start()
	
	// Update is called once per frame
	void Update ()
	{

		
	}  //End Update()


	public void OnTriggerEnter (Collider other)
	{
		//  if PlayerRocket enters the EnemyHitbox
		if (other.tag == "PlayerRocket") {

			//  Run kill() from EnemyAI
			enemy.kill ();

			//  Delete Rock
			Destroy(other.gameObject);


			// Reward 100 points to player's score
			gameManager.addScore (100);

			//Add one to the kill count of GameManager
			gameManager.addCount ();



		}
	}//End OnTriggerEnter(Collider other)

}//End EnemyHitBox()
