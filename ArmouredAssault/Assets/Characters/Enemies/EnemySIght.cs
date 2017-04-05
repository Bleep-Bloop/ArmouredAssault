using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySIght : MonoBehaviour {


	public EnemyAI thisEnemy;
	public bool canFire;

	// Use this for initialization
	void Start () {
		canFire = true;
	} //End Start()


	// Update is called once per frame
	void Update () {

		thisEnemy = GetComponentInParent<EnemyAI> ();

	} //End Update()

	void OnTriggerEnter(Collider other)
	{

		//if gameObject in TriggerZone is player && enemy can fire
		if (other.gameObject.tag == "Player" && canFire == true) {

			//Launch EnemyRocket
			thisEnemy.fire ();

			canFire = false;
		
			//Play waiting Coroutine to put delay on shots
			StartCoroutine (waiting ());

		}

	} //End OnTriggerEnter(Collider other)


	//Time untill next shot
	private IEnumerator waiting()
	{
		//Wait 2 seconds
		yield return new WaitForSecondsRealtime (2.0f);

		canFire = true;

	} //End waiting() 



} //End EnemySIght
