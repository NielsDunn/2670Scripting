using UnityEngine;
using System.Collections;

public class Howl : MonoBehaviour {

	[SerializeField] private AudioClip sfxHowl;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnTriggerEnter()
	{	
		audioSource.PlayOneShot (sfxHowl);
	}
}
