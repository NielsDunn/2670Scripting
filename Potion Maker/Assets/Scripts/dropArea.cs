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
			case 22:
				print ("You made a Fire Storm Potion! Make it rain....fire.");
				break;
			case 12:
				print ("You made a Fire Potion! It burns!");
				break;
			case 11:
				print ("It's a Fire Berry and a Mandragora. That's not a potion. ...The Mandragora tries to eat the Fire Berry.");
				break;
			case 10:
				print ("That's just a Mandragora. It winks.");
				break;
			case 3:
				print ("You made... THREE Fire Berries!!! ...Why not try adding some variety?");
				break;
			case 2:
				print ("You made... two Fire Berries. Keep trying.");
				break;
			case 1:
				print ("You made... a Fire Berry. What did you expect? You only added one ingredient!");
				break;
			default:
				print ("It's an unintelligible mess. Try a different combination of 3 ingredients.");
				break;
		}
	}

	public void ResetScore()
	{
		ingList.Clear();
		totalCalories = 0;
	}
}
