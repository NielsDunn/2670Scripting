using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CountdownTimer : MonoBehaviour {

	public GUIText timerText;
	public float timeLeft = 60.0f;


	// Use this for initialization
	void Start () {
	}
	
	void Update()
     {
         timeLeft -= Time.deltaTime;
		 timerText.text = timeLeft.ToString("f1");
         if(timeLeft <= 0)
         {
            RestartLevel();
         }
     }

	public void RestartLevel()
	{
		SceneManager.LoadScene(3);
	}
}
