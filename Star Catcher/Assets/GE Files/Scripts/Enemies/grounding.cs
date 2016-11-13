using UnityEngine;
using System.Collections;
[RequireComponent (typeof(CharacterController))]

public class grounding : MonoBehaviour {

	public Vector3 startPoint;
	private CharacterController cc;
	private float gravity = 2;
	private Vector3 tempP;
	public float speed = 1;

	private ScoreKeeper scoreKeeper;
	public int scoreValue;

	// Use this for initialization
	void Start () {
		startPoint = transform.position;
		cc = GetComponent<CharacterController>();

		//ScoreKeeping Stuff
		GameObject scoreKeeperObject = GameObject.FindWithTag ("ScoreKeeper");
        if (scoreKeeperObject != null)
        {
        	scoreKeeper = scoreKeeperObject.GetComponent <ScoreKeeper>();
        }
        if (scoreKeeper == null)
        {
        	Debug.Log ("Cannot find 'ScoreKeeper' Script");
        }
	}

	void OnTriggerEnter ()
	{	
		print ("Minus 50 Points");
		scoreKeeper.MinusScore (scoreValue);
		speed *= -1;
		//transform.position = startPoint;

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
