using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour, IDamageable {

	public int health = 100;
	public int respawnTime = 5;

	[SerializeField] Vector3 leftPosition;
	[SerializeField] Vector3 rightPosition;
	[SerializeField] float speed;

	// Use this for initialization
	void Start () {

		StartCoroutine (Move(rightPosition));

	}

	public void damageTaken ()
	{
		
	}

	public void Respawn ()
	{

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


}
