using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	
	public void MainMenu()
	{
		StartCoroutine("GameOver");
	}

	public void BattleScene()
	{
		StartCoroutine("Battle");
	}

	public void PotionMakingScene()
	{
		StartCoroutine("Potion");
	}

	IEnumerator GameOver()
	{
		float fadeTime = GameObject.Find("FadeManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene(0);
	}

	IEnumerator Battle()
	{
		float fadeTime = GameObject.Find("FadeManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene(1);
	}

	IEnumerator Potion()
	{
		float fadeTime = GameObject.Find("FadeManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene(2);
	}
}
