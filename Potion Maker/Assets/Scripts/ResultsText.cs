using UnityEngine;
using System.Collections;

public class ResultsText : MonoBehaviour {

	public GUIText messageText;
	
	// Use this for initialization
	void Start () {
        UpdateText ();
	}
	
	void UpdateText ()
    {
    	messageText.text = "Stars: ";
    }
}

