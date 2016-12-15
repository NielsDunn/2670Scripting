using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour, IDamageable {

	public delegate void DeathAction();
	public static event DeathAction OnHealthZero;

	private bool canSpawn = true;

	public static int health = 5;
	public int respawnTime = 5;

	public int maxEnemyNum = 3;


	public Vector3 leftPosition;
	public Vector3 rightPosition;
	public float speed;


	// Use this for initialization
	void Start () {

		string[] countdown = new string[4];

		countdown[0] = "Ready or not";
		countdown[1] = "Here";
		countdown[2] = "We";
		countdown[3] = "Go!";

		foreach(string number in countdown)
		{
			print(number);
		}

		StartCoroutine (Move(rightPosition));
		damageTaken();

		Respawn();

		myFunction(15);
	}

	public void Respawn()
	{
		for (int e = 0; e < maxEnemyNum;)
		{
			e++;

			print("There are " + e + " enemies.");
		}

		while (canSpawn)
		{
			print ("Let's spawn an enemy!");
			canSpawn = false;
		}

		do 
		{
			print ("We spawned an enemy!");
		} while(canSpawn == true);

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

	void OnTriggerEnter(Collider en)
	{
		health--;
		damageTaken();
		}

	public void damageTaken ()
	{
		switch (health)
		{
			case 4:
				speed++;
				print ("Ow.");
				break;
			case 3:
				speed++;
				print ("You're hurting me.");
				break;
			case 2:
				speed++;
				print ("I'm dying.");
				break;
			case 1:
				speed++;
				print ("I'm almost dead.");
				break;
			case 0:
				speed = speed - 9;
				print ("I'm dead.");
				StartCoroutine("GameOver");
				break;
			default:
				print ("Haven't been hit yet");
				break;
		}
	}

	void OnGUI()
	{
		if(health ==0)
		{
			if(OnHealthZero !=null)
				OnHealthZero();
		}
	}

	static void myFunction(int x)
	{
		int Answer;

		Answer = 5 * x;

		print ("My answer is " + Answer);
	}

	public int MultiplybyFive(int x) {
		return x * 5;
	}

	IEnumerator GameOver()
	{
		float fadeTime = GameObject.Find("FadeManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene(0);

	}

 }

