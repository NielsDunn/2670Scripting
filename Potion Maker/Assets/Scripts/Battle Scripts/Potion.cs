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

		potionTypes = new string[3]; 

		potionTypes[0] = "Fire Potion";
		potionTypes[1] = "Ice Potion";
		potionTypes[2] = "Lightning Potion";
		
		rigidBody = GetComponent<Rigidbody> ();
		spawnPosition = transform.position;
		PotionCount();
	}

	void OnMouseUp()
	{
		rigidBody.AddForce(new Vector3(0, upwardForce, forwardForce), ForceMode.Impulse);
		potionNum--;
		PotionCount();
	}

	public void Refill ()
	{
		throw new System.NotImplementedException ();
	}

	void OnTriggerEnter ()
	{
		transform.position = spawnPosition;
		GetComponent<Rigidbody>().Sleep();
	}

	void PotionCount()
	{
		print("You threw a " + potionTypes[Random.Range (0,2)] + "!");
	}
}
