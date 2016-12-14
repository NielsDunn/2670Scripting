using UnityEngine;
using System.Collections;
[RequireComponent (typeof(CharacterController))]

public class grounding : MonoBehaviour {

	public Vector3 startPoint;
	private CharacterController cc;
	private float gravity = 2;
	private Vector3 tempP;
	public float speed = 1;

	// Use this for initialization
	void Start () {
		startPoint = transform.position;
		cc = GetComponent<CharacterController>();


	}

	void OnTriggerEnter ()
	{
		transform.position = startPoint;

	}
	
	// Update is called once per frame
	void Update () {
		//print (cc.velocity);
		tempP.y = -gravity;
		cc.Move(tempP*Time.deltaTime);
		if (cc.isGrounded)
		{
			tempP.x = speed;
		} else 
		{
			tempP.x = 0;
		}
	}

}
