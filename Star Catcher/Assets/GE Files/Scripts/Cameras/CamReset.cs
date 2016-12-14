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
		yield return new WaitForSeconds (1.0f);
		Application.LoadLevel(3);

	}

}
