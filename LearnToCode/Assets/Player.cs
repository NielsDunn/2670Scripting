using UnityEngine;
using System.Collections;

public class Player : Humanoid {

	private int spinAttackDamage = 10;

	public override int Attack()
	{
		return attackDamage + spinAttackDamage;
	}
}
