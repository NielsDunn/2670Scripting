using UnityEngine;
using System.Collections;
using System;

public class sendToRecycler : MonoBehaviour {

	public bool canRecycle = false;
		
	public static Action<sendToRecycler> SendThis;

	// Use this for initialization
	void Start () {
		if (canRecycle)
			SendThis(this);
	}

	void OnTriggerEnter()
	{
		canRecycle = true;
		Start();
	}
}
