using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public NavMeshAgent navAgent;
	public Transform player;
	
	// Update is called once per frame
	void Update () {
		navAgent.destination = player.position;
	}
}
