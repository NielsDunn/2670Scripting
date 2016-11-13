using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

	private NavMeshAgent myAgent;
	public Transform player;
	public Animator myAnims;


	// Use this for initialization
	void Start () {
		myAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

		myAgent.destination = player.position;

		if (myAgent.isOnOffMeshLink)
		{
			myAnims.SetBool("Jump", true);
			print(myAgent.isOnOffMeshLink);
		}

	}
}
