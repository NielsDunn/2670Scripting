using UnityEngine;
using System.Collections;

public class ShipBase : MonoBehaviour, IDamage, IAttack {


	// Use this for initialization
	public virtual void Start () {
	 Attack();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void Damage ()
	{
		
	}


	public void Attack ()
	{
		print("Attacking");
	}
}
