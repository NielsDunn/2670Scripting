using UnityEngine;
using System.Collections;

public class EnemyShip : ShipBase {

	// Use this for initialization
	public override void Start () {
		base.Start();
		Chase();
	}

	private void Chase()
	{
		print ("Chasing");
	}
	

}
