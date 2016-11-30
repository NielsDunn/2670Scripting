using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel()
	{
		Debug.Log ("New Level load: " + name);
		SceneManager.LoadScene(2);
	}

	public void QuitRequest()
	{
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public void MainMenu()
	{
		Debug.Log ("Go to Main Menu");
		SceneManager.LoadScene(1);
	}

}
