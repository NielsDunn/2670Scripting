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
		StartCoroutine("QuitWait");
	}

	public void MainMenu()
	{
		StartCoroutine("MainMenuRequest");
	}

	IEnumerator Wait()
	{
		float fadeTime = GameObject.Find("FadeManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (2.6f);
		Application.LoadLevel(2);

	}

	IEnumerator QuitWait()
	{
		float fadeTime = GameObject.Find("FadeManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (2.6f);
		Application.Quit ();

	}

	IEnumerator MainMenuRequest()
	{
		float fadeTime = GameObject.Find("FadeManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (2.6f);
		Application.LoadLevel(Application.loadedLevel - 2);
	}


}
