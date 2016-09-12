using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public float camSpeed = 10.0f;


	void Update () {
         transform.Translate(Vector3.right * Time.deltaTime * camSpeed);
 
     }

	void OnTriggerEnter(Collider collider){
		this.transform.position = new Vector3 (0f, 2f, -10f);
 		}
}
