using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : MonoBehaviour {

	public EnemyAI enemy;

	// Use this for initialization
	void Start () {

		//
		enemy = GetComponentInParent<EnemyAI>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "PlayerRocket") {
			enemy.kill ();
			Debug.Log ("You killed me");
		}
		}

}
