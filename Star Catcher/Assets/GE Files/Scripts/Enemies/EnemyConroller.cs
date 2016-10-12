using UnityEngine;
using System.Collections;

public class EnemyConroller : MonoBehaviour {

	public CharacterController myCC;
	public float gravity = 1;
	public Vector3 tempPos;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tempPos.y -= gravity*Time.deltaTime;
		myCC.Move(tempPos);
	}
}
