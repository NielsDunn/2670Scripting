using UnityEngine;
using System.Collections.Generic;

public class dropArea : MonoBehaviour {

	public List<Ingredient> ingList;

	public bool active = false;

	public int potionMade;

	public GUIText messageText;

	void OnTriggerEnter(Collider ing)
	{
		ingList.Add(ing.GetComponent<Ingredient>());
		//active = true;
	}

	public void TotalScore()
	{
		foreach (Ingredient i in ingList)
			{
				potionMade += i.ingNum;
			}
			MessageSwitch();
			ResetScore();

	}

	void MessageSwitch()
	{
		switch(potionMade)
		{
			case 150:
				messageText.text = "Too many Slimes!";
				print ("Too many Slimes!");
				break;
			case 120:
			messageText.text = "You made a Drowning Swamp Potion! Don't follow the lights.";
				print ("You made a Drowning Swamp Potion! Don't follow the lights....");
				break;
			case 101:
				print ("You made a Warm Sea Potion! Surf's up dude!");
				break;
			case 100:
				print ("The two Slimes just join together to form a Big Blue Slime. It jiggles.");
				break;
			case 90:
				print ("You made a Wild Growth Potion! Hope you brought a Machete!");
				break;
			case 71:
				print ("You made a Panacea! This will cure all wounds! So much more than a hard-to-pronounce name!");
				break;
			case 52:
				print ("You made a Boiling Water Potion! Use it to cook food or scald your enemies! Or both!");
				break;
			case 51:
				messageText.text = "The Fire Berry floats in the Slime. It looks like a bad Jello Mold.";
				print ("The Fire Berry floats in the Slime. It looks like a bad Jello Mold.");
				break;
			case 50:
				messageText.text = "That's just a Blue Slime. Jiggly...";
				print ("That's just a Blue Slime. Jiggly...");
				break;
			case 41:
				messageText.text = "You made a Wildfire Potion! Set the hills ablaze! Watch out for self-righteous bears in hats though.";
				print ("You made a Wildfire Potion! Set the hills ablaze! Watch out for self-righteous bears in hats though.");
				break;
			case 22:
				messageText.text = "You made a Fire Storm Potion! Make it rain....fire.";
				print ("You made a Fire Storm Potion! Make it rain....fire.");
				break;
			case 21:
				messageText.text = "You made a Briar Thorn Potion! Every rose has it's thorns!!! And these thorns are on fire!";
				print ("You made a Briar Thorn Potion! Every rose has it's thorns!!! And these thorns are on fire!");
				break;
			case 20:
				messageText.text = "The two Mandragoras kiss. Eeew.";
				print ("The two Mandragoras kiss. Eeew.");
				break;
			case 12:
				messageText.text = "You made a Fire Potion! It burns!";
				print ("You made a Fire Potion! It burns!");
				break;
			case 11:
				messageText.text = "It's a Fire Berry and a Mandragora. That's not a potion. ...The Mandragora tries to eat the Fire Berry.";
				print ("It's a Fire Berry and a Mandragora. That's not a potion. ...The Mandragora tries to eat the Fire Berry.");
				break;
			case 10:
				messageText.text = "That's just a Mandragora. It winks.";
				print ("That's just a Mandragora. It winks.");
				break;
			case 3:
				messageText.text = "You made... THREE Fire Berries!!! ...Why not try adding some variety?";
				print ("You made... THREE Fire Berries!!! ...Why not try adding some variety?");
				break;
			case 2:
				messageText.text = "You made... two Fire Berries. Keep trying.";
				print ("You made... two Fire Berries. Keep trying.");
				break;
			case 1:
				messageText.text = "You made... a Fire Berry. What did you expect? You only added one ingredient!";
				print ("You made... a Fire Berry. What did you expect? You only added one ingredient!");
				break;
			default:
				messageText.text = "It's an unintelligible mess. Try a different combination of 3 ingredients.";
				print ("It's an unintelligible mess. Try a different combination of 3 ingredients.");
				break;
		}
	}

	public void ResetScore()
	{
		ingList.Clear();
		potionMade = 0;	
	}
}
