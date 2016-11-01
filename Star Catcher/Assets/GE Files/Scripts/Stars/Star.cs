using UnityEngine;
using System.Collections;
using System;

public class Star : MonoBehaviour {

	public static Action<Transform> SendStar;

	// Use this for initialization
	void Start () {
		GetComponent<MeshRenderer>().enabled = false;
		if(SendStar != null){
			SendStar(transform);
		}
	}

}
