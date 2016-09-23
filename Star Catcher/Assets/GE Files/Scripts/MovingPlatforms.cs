using UnityEngine;
using System.Collections;

public class MovingPlatforms : MonoBehaviour {
	public float speed = 1f;
	
	// Update is called once per frame
	void Update () {
		MovePlatform();
	}

	void MovePlatform()
	{
		transform.Translate (Vector3.left * speed * Time.deltaTime);
	}
}
