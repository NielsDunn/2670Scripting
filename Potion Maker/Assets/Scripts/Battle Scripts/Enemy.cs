using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour, IDamageable {

	public int health = 100;

	public int respawnTime = 5;

	public float smoothing = 10f;
    public Transform targetLeft;
    public Transform targetRight;

	// Use this for initialization
	void Start () {

		StartCoroutine(moveLeft(targetLeft));

	}

	public void damageTaken ()
	{
		
	}

	public void Respawn ()
	{
		throw new System.NotImplementedException ();
	}

	IEnumerator moveLeft (Transform targetLeft)
    {
        while(Vector3.Distance(transform.position, targetLeft.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, targetLeft.position, smoothing * Time.deltaTime);
            
            yield return null;
        }
        
        print("Reached the target.");
        
        yield return new WaitForSeconds(1f);
        
        StartCoroutine(moveRight(targetRight));
    }

	IEnumerator moveRight (Transform targetRight)
    {
        while(Vector3.Distance(transform.position, targetRight.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, targetRight.position, smoothing * Time.deltaTime);
            
            yield return null;
        }
        
        print("Reached the target.");
        
        yield return new WaitForSeconds(1f);
        
        StartCoroutine(moveLeft(targetLeft));
    }

}
