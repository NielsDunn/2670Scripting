using UnityEngine;
using System.Collections;

public class PlayerShip : ShipBase {

	public override void Start()
	{
		base.Start();
		Move();
	}

	void Move()
	{
		print("Moving with character controller");
	}
}
