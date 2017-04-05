using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHitbox : MonoBehaviour {

	public GameManager gameManager;
	public Text scoreText;

	public EnemyAI enemy;

	// Use this for initialization
	void Start () {

		//
		enemy = GetComponentInParent<EnemyAI>();
		//score = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<Text> ();
		gameManager = GameManager.FindObjectOfType<GameManager>();
		scoreText = gameManager.GetComponentInChildren<Text> ();


	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "PlayerRocket") {
			enemy.kill ();
			Debug.Log ("You killed me");
			gameManager.addScore (100);
			gameManager.addCount();

		}
		}

}
