using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		StartCoroutine("Countdown");	
	}
	
	private IEnumerator Countdown()
	{
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene (1);
	}
}
