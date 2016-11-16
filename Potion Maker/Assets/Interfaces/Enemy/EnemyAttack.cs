using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour, IAttack, IDamage {

	// Use this for initialization
	void Start () {
		Attack();
		Damage();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void Attack ()
	{
		print("I am attacking");
	}

	public void Damage ()
	{
		print ("Damage All");
	}

}
