using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public GameObject player;
	public Rigidbody rb;
	public float speed = 10.0f;
	public float gravity = 20.0f;	
	public  bool grounded = true;
	public int jumpCount = 1;

	//Sliding Vars
	public int slideDuration = 100;
	public float slideTime = 0.1f;

	void Start (){
		rb = GetComponent<Rigidbody>();
	}

	//Coroutine for Sliding the character
	IEnumerator Slide ()
	{
		//Set a temp var to the value of slideDuration
		int durationTemp = slideDuration;
		//
		float speedTemp = speed;
		speed += speed;
		//While loop runs "while" the slideDuration is greater than 0
		while (slideDuration > 0)
		{
			//Decrement the slideDuration
			slideDuration--;
			//yield "holds the coroutine"
			//return "sends" to the coroutine to do an operation while yielding
			//New creates an instance of an object
			//WaitForSeconds is an object that waits for a duration of time
			yield return new WaitForSeconds(slideTime);

		}
		speed = speedTemp;
		slideDuration = durationTemp;
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && grounded == true) {
			rb.velocity = new Vector3(0, 6, 0);
			jumpCount --;
		}else if (Input.GetKeyDown(KeyCode.Space) && jumpCount > 0){
			rb.velocity = new Vector3(0, 6, 0);
			jumpCount--;
		}

	//Start Sliding
		if(Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
		{
			//StartCoroutine is a function that calls a coroutine. Use the coroutine in the arguement.
			StartCoroutine(Slide());
		}

		if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
		{
			//StartCoroutine is a function that calls a coroutine. Use the coroutine in the arguement.
			StartCoroutine(Slide());
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