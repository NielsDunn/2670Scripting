using UnityEngine;
using System.Collections;

public class Potion : MonoBehaviour, IReuseable {

	public int potionNum = 5;
	
	public float upwardForce = 3f;
	public float forwardForce = 1f;
	private Vector3 spawnPosition;

	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
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
		for (int p = 0; p < potionNum; p++)
		{
			print ("Potions in pool: " + p);
		}
	}
}
