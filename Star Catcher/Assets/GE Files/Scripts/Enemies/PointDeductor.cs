using UnityEngine;
using System.Collections;

public class PointDeductor : MonoBehaviour {

	private ScoreKeeper scoreKeeper;
	public int scoreValue;

	[SerializeField] private AudioClip sfxShatter;

    private AudioSource audioSource;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
		
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

	void OnTriggerEnter()
	{	
		print ("Minus 50 Points");
		scoreKeeper.MinusScore (scoreValue);
		audioSource.PlayOneShot (sfxShatter);
	}
}
