using UnityEngine;
using System.Collections;

public interface IPowerUp {

	int power { get;

	}

	void Start();

	void OnTriggerEnter();
}
