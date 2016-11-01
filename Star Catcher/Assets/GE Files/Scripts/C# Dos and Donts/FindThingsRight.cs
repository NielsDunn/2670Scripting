using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FindThingsRight : MonoBehaviour {

	public List <GameObject> level;

	void AddToList (GameObject _go)
	{
		level.Add(_go);
	}

	// Use this for initialization
	void Start () {
		SendThisRight.SendThis += AddToList;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
