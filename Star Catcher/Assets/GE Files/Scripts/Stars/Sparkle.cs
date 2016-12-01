using UnityEngine;
using System.Collections;

public class Sparkle : MonoBehaviour {

	private ParticleSystem _psystem;

	void Awake()
	{
		_psystem = GetComponent<ParticleSystem>();
	}

	void Start ()
	{
		//sparkle.GetComponent<ParticleSystem> ().enableEmission = false;
	}

	void OnCollisionEnter(Collision col)
	{
		print ("Hit Ground");
		_psystem.Play();
	}

}
