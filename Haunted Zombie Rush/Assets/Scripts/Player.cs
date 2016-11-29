using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	[SerializeField] private float forceAmount = 50f;
	[SerializeField] private AudioClip sfxJump;

	private Animator anim;
	private Rigidbody rigidBody;
	private bool jump = false;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rigidBody = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetMouseButtonDown (0)) 
		{
			anim.Play("Jump");
			audioSource.PlayOneShot(sfxJump);
			rigidBody.useGravity = true;
			jump = true;
		}
	
	}

	void FixedUpdate()
	{
		if (jump == true) 
		{
			jump = false;
			rigidBody.velocity = new Vector2 (0,0);
			rigidBody.AddForce(new Vector2(0, forceAmount), ForceMode.Impulse);
		}

	}
}
