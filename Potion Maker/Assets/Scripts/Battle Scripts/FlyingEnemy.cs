using UnityEngine;
using System.Collections;

public class FlyingEnemy : Enemy {

	void Start()
	{
		StartCoroutine (Move(leftPosition));
	}

	IEnumerator Move(Vector3 target)
	{
		while (Mathf.Abs((target - transform.localPosition).x) > 0.20f) 
		{
			Vector3 direction = target.x == rightPosition.x ? Vector3.right : Vector3.left;
			transform.localPosition += direction * Time.deltaTime * speed;

			yield return null;
		}

		yield return new WaitForSeconds (0.5f);

		Vector3 newTarget = target.x == rightPosition.x ? leftPosition : rightPosition;

		StartCoroutine(Move(newTarget));
	}

}
