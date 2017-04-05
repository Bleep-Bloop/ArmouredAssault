using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySIght : MonoBehaviour {


	public EnemyAI thisEnemy;
	public bool canFire;

	// Use this for initialization
	void Start () {

		canFire = true;

	}
	
	// Update is called once per frame
	void Update () {

		thisEnemy = GetComponentInParent<EnemyAI> ();

	}

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player" && canFire == true) {

			Debug.Log ("Fire at player");


			thisEnemy.fire ();



			canFire = false;

			StartCoroutine (waiting ());


		}

	}


	//Time untill next shot
	private IEnumerator waiting()
	{
		yield return new WaitForSecondsRealtime (2.0f);
		canFire = true;

	}



}
