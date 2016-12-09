using UnityEngine;
using System.Collections;

public class Potion : MonoBehaviour, IReuseable {
	
	public float upwardForce = 3f;
	public float forwardForce = 1f;
	private Transform startPosition;

	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
	}

	void OnMouseUp()
	{
		rigidBody.AddForce(new Vector3(0, upwardForce, forwardForce), ForceMode.Impulse);
	}

	public void Refill ()
	{
		throw new System.NotImplementedException ();
	}

	void OnTriggerEnter ()
	{

	}
}
