using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public GameObject player;
	public Rigidbody rb;
	public float speed = 15.0f;
	public float gravity = 20.0f;	
	public  bool grounded = true;
	public int jumpCount = 1;

	void Start (){
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && grounded == true) {
			rb.velocity = new Vector3(0, 6, 0);
			jumpCount --;
		}else if (Input.GetKeyDown(KeyCode.Space) && jumpCount > 0){
			rb.velocity = new Vector3(0, 6, 0);
			jumpCount--;
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.position += Vector3.left * speed * Time.deltaTime;
		}else if (Input.GetKey(KeyCode.RightArrow)){
			transform.position += Vector3.right * speed * Time.deltaTime; 
		}
		
	}

		void OnCollisionEnter(){
    		 grounded = true;
    		 jumpCount = 2;
		 }		
 		void OnCollisionExit(){
    		 grounded = false;
   
 		}

 		void OnTriggerEnter(Collider collider){
			this.transform.position = new Vector3 (0f, 0f, 0f);
 		}
}