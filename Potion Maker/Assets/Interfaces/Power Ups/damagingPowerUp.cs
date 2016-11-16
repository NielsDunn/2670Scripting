using UnityEngine;
using System.Collections;

public class damagingPowerUp : MonoBehaviour, IDamage {

	public void Damage ()
	{
		print ("Damaged Player");
	}

	// Use this for initialization
	void Start () {
		Damage();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
