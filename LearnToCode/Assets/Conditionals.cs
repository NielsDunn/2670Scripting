using UnityEngine;
using System.Collections;

public class Conditionals : MonoBehaviour {

	int playerOneTowersRemaining = 2;
	int playerTwoTowersRemaining = 2;
	bool playerOneMainTowerDestroyed = false;
	bool playerTwoMainTowerDestroyed = false;
	float timer = 200;

	// Use this for initialization
	void Start () {

		if (playerOneMainTowerDestroyed || playerTwoMainTowerDestroyed)
		{
			if (playerOneMainTowerDestroyed) 
			{
				Debug.Log ("Player Two Wins!");
			} else 
			{
				Debug.Log ("Player One Wins!");
			}
		} else if (timer <= 0)
		{
			if (playerOneTowersRemaining < playerTwoTowersRemaining)
			{
				Debug.Log ("Player Two Wins!");
			} else if (playerTwoTowersRemaining < playerOneTowersRemaining)
			{
				Debug.Log ("Player One Wins!");
			} else 
			{
				Debug.Log ("The Game was a Draw!");
			}
		}

		if (true == false || false != true && 1 == 1)
		{
		Debug.Log ("Did we get here?");
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
