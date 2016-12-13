using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Potion : MonoBehaviour, IReuseable {

	public string[] potionTypes;

	public int potionNum = 5;
	
	public float upwardForce = 3f;
	public float forwardForce = 1f;
	private Vector3 spawnPosition;

	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {

		List<PotionTypes> potiontypes = new List<PotionTypes>();

		potiontypes.Add (new PotionTypes ("Fire Potion", 100, 5));
		potiontypes.Add (new PotionTypes ("Ice Potion", 200, 5));
		potiontypes.Add (new PotionTypes ("Lightning Potion", 300, 5));

		potiontypes.Sort();

		foreach (PotionTypes potion in potiontypes)
		{
			print (potion.potionName + " " + potion.strength + " " + potion.numCharge + " charges left.");
		}

		potiontypes.Clear();

		potionTypes = new string[3]; 

		potionTypes[0] = "Fire Potion";
		potionTypes[1] = "Ice Potion";
		potionTypes[2] = "Lightning Potion";
		
		rigidBody = GetComponent<Rigidbody> ();
		spawnPosition = transform.position;
	}

	void OnMouseUp()
	{
		rigidBody.AddForce(new Vector3(0, upwardForce, forwardForce), ForceMode.Impulse);
		potionNum--;

	}

	public void Refill ()
	{
		throw new System.NotImplementedException ();
	}

	void OnTriggerEnter ()
	{
		PotionType();
		
		transform.position = spawnPosition;
		GetComponent<Rigidbody>().Sleep();
	}

	void PotionType()
	{
		print("You threw a " + potionTypes[Random.Range (0,2)] + "!");
	}
}
