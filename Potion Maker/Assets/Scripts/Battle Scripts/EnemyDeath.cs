using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour {

	void OnEnable()
	{
		Enemy.OnHealthZero += ChangeonDeath;
	}

	void OnDisable()
	{
		Enemy.OnHealthZero -= ChangeonDeath;
	}

	void ChangeonDeath()
	{
		Color col = new Color(100,0,0);
		GetComponent<Renderer>().material.color = col;
	}
}
