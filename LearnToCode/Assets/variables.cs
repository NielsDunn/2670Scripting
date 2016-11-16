using UnityEngine;
using System.Collections;

public class variables : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string heroName = "Thanos";
		string equippedWeapon = "Infinity Gauntlet";
		string favoriteFurniture = "Throne";

		string favoritePlanet;

		favoritePlanet = "Earth";

		Debug.Log (favoritePlanet);

		Debug.Log (heroName);
		Debug.Log (equippedWeapon);
		Debug.Log (favoriteFurniture);

		Debug.Log (equippedWeapon.ToUpper());

		int hp = 100;
		float shieldPower = 76.5f;
		int laserDamage = 30;
		double actualDamagePercent = .05;

		int actualDamage = (int)(laserDamage * actualDamagePercent);

		hp -= actualDamage; //hp = hp - actualDamage

		shieldPower = shieldPower - (laserDamage - actualDamage);

		Debug.Log ("HP: " + hp);
		Debug.Log ("Shield Power: " + shieldPower);

		int slices = 10 / 5;

		Debug.Log ("Slices: " + slices);

		int newDamage = 10 / 3;

		print (newDamage);

		int newDamageRemainder = 10 % 3;

		print ("10 divided by 3 equals " + newDamage + " with a remainder of " + newDamageRemainder);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
