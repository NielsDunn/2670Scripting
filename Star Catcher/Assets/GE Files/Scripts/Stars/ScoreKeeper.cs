using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public GUIText scoreText;
    private int score;
	
	// Use this for initialization
	void Start () {
		score = 0;
        UpdateScore ();
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	public void MinusScore (int newScoreValue)
	{
		score -= newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore ()
    {
    	scoreText.text = "Score " + score;
    }
}
