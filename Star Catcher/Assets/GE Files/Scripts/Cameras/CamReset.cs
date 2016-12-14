using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CamReset : MonoBehaviour {

	void OnTriggerEnter()
	{
		StartCoroutine("GameOver");
	}

	IEnumerator GameOver()
	{
		float fadeTime = GameObject.Find("FadeManager").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		Application.LoadLevel(3);

	}

}
