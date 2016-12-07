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
			//print(totalCalories);
			MessageSwitch();
			ResetScore();
	}

	 public void ResetScore()
	{
		ingList.Clear();
		totalCalories = 0;
	}

	void MessageSwitch()
	{
		switch(totalCalories)
		{
			case 9:
				print ("9");
				break;
			case 8:
				print ("8");
				break;
			case 7:
				print ("7");
				break;
			case 6:
				print ("6");
				break;
			case 5:
				print ("5");
				break;
			case 4:
				print ("4");
				break;
			case 3:
				print ("3");
				break;
			case 2:
				print ("2");
				break;
			case 1:
				print ("1");
				break;
			default:
				print ("error");
				break;
		}
	}
}
