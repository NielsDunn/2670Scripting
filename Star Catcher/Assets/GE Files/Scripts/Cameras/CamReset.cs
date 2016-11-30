using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CamReset : MonoBehaviour {

	void OnTriggerEnter()
	{
		RestartLevel();
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene(3);
	}

}
