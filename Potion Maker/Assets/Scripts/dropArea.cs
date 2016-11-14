using UnityEngine;
using System.Collections;

public class dropArea : MonoBehaviour {

	public bool active = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter()
	{
		active = true;
	}

	void OnMouseUp()
	{
		if(active == true) 
		{
			print("Ingredient Added");
		}
	}
}
