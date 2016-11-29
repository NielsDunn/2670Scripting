using UnityEngine;
using System.Collections;

public class movePlatform : MonoBehaviour 
{

	[SerializeField] private float objectSpeed = 1;
	[SerializeField] private float resetPosition = -0.4f;
	[SerializeField] private float startPosition = 87.6f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * (objectSpeed * Time.deltaTime));

		if (transform.localPosition.x <= resetPosition)
		{
			Vector3 newPos = new Vector3(startPosition, transform.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}
