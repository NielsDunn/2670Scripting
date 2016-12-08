using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour, IDamageable {

	public int health = 100;

	public int respawnTime = 5;

	// Use this for initialization
	void Start () {
	
	}

	public void damageTaken ()
	{
		throw new System.NotImplementedException ();
	}

	public void Respawn ()
	{
		throw new System.NotImplementedException ();
	}
}
