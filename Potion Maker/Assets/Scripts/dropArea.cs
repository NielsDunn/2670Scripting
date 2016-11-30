using UnityEngine;
using System.Collections.Generic;

public class dropArea : MonoBehaviour {

	public List<Ingredient> ingList;

	public bool active = false;

	public int totalCalories;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider ing)
	{
		ingList.Add(ing.GetComponent<Ingredient>());
		//active = true;
	}

	void OnMouseUp()
	{
//		if(active == true) 
//		{
//			
//		}
		foreach (Ingredient i in ingList)
			{
				totalCalories += i.calories;
			}
			print(totalCalories);
	}
}
