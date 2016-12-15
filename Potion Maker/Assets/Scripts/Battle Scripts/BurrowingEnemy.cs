using UnityEngine;
using System.Collections;

public class BurrowingEnemy : Enemy {

	public Vector3 topPosition;
	public Vector3 bottomPosition;

	void Start()
	{
		StartCoroutine (Move(rightPosition));
		StartCoroutine (Dive(topPosition));
	}

	IEnumerator Move(Vector3 target)
	{
		while (Mathf.Abs((target - transform.localPosition).x) > 0.20f) 
		{
			Vector3 direction = target.x == leftPosition.x ? Vector3.left : Vector3.right;
			transform.localPosition += direction * Time.deltaTime * speed;

			yield return null;
		}

		yield return new WaitForSeconds (0.5f);

		Vector3 newTarget = target.x == leftPosition.x ? rightPosition : leftPosition;

		StartCoroutine(Move(newTarget));
	}

	IEnumerator Dive(Vector3 target)
	{
		while (Mathf.Abs((target - transform.localPosition).y) > 0.20f) 
		{
			Vector3 direction = target.y == topPosition.y ? Vector3.up : Vector3.down;
			transform.localPosition += direction * Time.deltaTime * speed;

			yield return null;
		}

		yield return new WaitForSeconds (0.5f);

		Vector3 newTarget = target.y == topPosition.y ? bottomPosition : topPosition;

		StartCoroutine(Dive(newTarget));
	}
	void OnTriggerEnter()
	{
		print ("Wow you actually hit that? Nice job!");
		transform.position = new Vector3 (0, -5, 0);
	}
}
