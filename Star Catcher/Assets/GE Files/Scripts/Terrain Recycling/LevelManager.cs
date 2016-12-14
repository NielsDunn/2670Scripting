using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel()
	{
		StartCoroutine("Wait");
	}

	public void QuitRequest()
	{
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public void MainMenu()
	{
		Debug.Log ("Go to Main Menu");
		Application.LoadLevel(Application.loadedLevel - 2);
	}

	IEnumerator Wait()
	{
		float fadeTime = GameObject.Find("FadeManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (2.6f);
		Application.LoadLevel(Application.loadedLevel +1);

	}

}
