using UnityEngine;
using System.Collections;

public class PlayerParticles : MonoBehaviour {

	private ParticleSystem _psystem;

	void Awake()
	{
		_psystem = GetComponent<ParticleSystem>();
	}

	void Start ()
	{
		//sparkle.GetComponent<ParticleSystem> ().enableEmission = false;
	}

	void OnTriggerEnter()
	{
		print ("Hit Start");
		_psystem.Play();
	}
}
