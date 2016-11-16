using UnityEngine;
using System.Collections;

public class UpTownFunctionYouUp : MonoBehaviour {

	int health = 100;
	int attackPower = 25;
	bool shieldOn = true;
	int shieldAmt = 15;

	void Start()
	{
		Debug.Log ("Health: " + health);
	}

	public void Attack()
	{
		int damageToInflict = GetAttackDamage(shieldOn,shieldAmt,attackPower);
		health -= damageToInflict;
		Debug.Log("Health: " + health);
	}

	public void Heal()
	{
		int healAmount = GetRandomNumber ();
		health += healAmount;

		Debug.Log ("Received " + healAmount + " health");
		Debug.Log ("You now have " + health + " health");
	}

	private int GetAttackDamage(bool isShieldOn, int theShieldAmt, int theAttackPower)
	{
		int damage = 0;
		if (isShieldOn)
		{
			damage = theAttackPower - (int)((float)theShieldAmt * 0.10f);
		} else 
		{
			damage = theAttackPower;
		}

		return damage;
	}

	private int GetRandomNumber()
	{
		return Random.Range(2, 10);
	}


}
