using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

	public string[] animals = {"cat", "dog", "rabbit", "bear", "student", "fox"};

	// Use this for initialization
	void Start () {

		for (int i = 0; i < animals.Length; i++){

			print ("The " + animals[i] + " ate my taco.");

		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
