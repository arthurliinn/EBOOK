using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewApple : MonoBehaviour {

	Vector3 TargetPosition;
	Vector3 TargetPosition2;

	public GameObject ground;
	public bool appleF = false;
	public GameObject text1;
	public GameObject text2;

	// Use this for initialization
	void Start () {

		TargetPosition = transform.position;
		TargetPosition2 = Camera.main.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector3.MoveTowards (transform.position, TargetPosition, 0.3f);
		   


		if (appleF == false) {
			if (Input.GetMouseButtonDown (0) && Vector2.Distance (Camera.main.ScreenToWorldPoint (Input.mousePosition), transform.position) < 0.5f) {

				TargetPosition = new Vector3 (15.6f, -3.4f, 0); 

				//print ("asdasdAS");
				appleF = true;

			}
		}

		if (appleF == true) {



			//print ("FFFFFFFFFFFFFFFFF");
			if(this.transform.position == ground.transform.position){

				text1.SetActive (true);
				text2.SetActive (false);
				
			    if (Input.GetMouseButtonDown (0) && Vector2.Distance (Camera.main.ScreenToWorldPoint (Input.mousePosition), transform.position) < 0.5f) {


				CameraControl.Apple = true;

					Destroy (this.gameObject);
					

				//print ("sssdasdasds");
			    }
			}


		}

	}
}
