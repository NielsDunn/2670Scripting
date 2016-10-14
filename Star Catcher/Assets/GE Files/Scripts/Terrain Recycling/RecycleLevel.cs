using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevel : MonoBehaviour {

	public List<sendToRecycler> recycleList;
	private Vector3 movePos;

	void SendThisHandler (sendToRecycler _r) 
	{
		recycleList.Add(_r);
		print(recycleList.Count);
	}

	// Use this for initialization
	void Start () {
		recycleList = new List<sendToRecycler>();
		sendToRecycler.SendThis += SendThisHandler;
		Statics.nextPosition = 53.8f;
	}

	void OnTriggerEnter ()
	{
		int i = UnityEngine.Random.Range(0, recycleList.Count - 1);
		movePos.x = Statics.nextPosition;
		recycleList[i].transform.position = movePos;
		recycleList.RemoveAt(i);
		Statics.nextPosition += Statics.distance;
	}
}
