using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public void BattleScene()
	{
		SceneManager.LoadScene(1);
	}

	public void PotionMakingScene()
	{
		SceneManager.LoadScene(2);
	}
}
