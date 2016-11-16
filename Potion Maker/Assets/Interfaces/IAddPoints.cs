using UnityEngine;
using System.Collections;

public interface IAddPoints {

	int points { get; set; }

	int AddPoints();

	void OnTriggerEnter();
}
