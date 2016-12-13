using UnityEngine;
using System.Collections;
using System;

public class PotionTypes : Potion, IComparable<PotionTypes> {

	public string potionName;
	public int strength;
	public int numCharge;

	public PotionTypes (string newName, int newStrength, int newnumCharge)
	{
		potionName = newName;
		strength = newStrength;
		numCharge = newnumCharge;
	}

	public int CompareTo(PotionTypes other)
	{
		if (other == null)
		{
			return 1;
		}

		return strength = other.strength;
	}
}
