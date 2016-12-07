using UnityEngine;
using System.Collections.Generic;

public class dropArea : MonoBehaviour {

	public List<Ingredient> ingList;

	public bool active = false;

	public int totalCalories;

	void OnTriggerEnter(Collider ing)
	{
		ingList.Add(ing.GetComponent<Ingredient>());
		//active = true;
	}

	public void TotalScore()
	{
		foreach (Ingredient i in ingList)
			{
				totalCalories += i.calories;
			}
			print(totalCalories);
			ResetScore();
	}

	 public void ResetScore()
	{
		ingList.Clear();
		totalCalories = 0;
	}
}
