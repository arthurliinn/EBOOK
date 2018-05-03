using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour {

	Vector3 TargetPosition;
	public bool END;

	// Use this for initialization
	void Start () {
		//TargetPosition = Camera.main.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {


		//Camera.main.transform.position = Vector3.MoveTowards (Camera.main.transform.position, TargetPosition, 0.1f);

		if (Input.GetMouseButtonDown (0) && Vector2.Distance (Camera.main.ScreenToWorldPoint (Input.mousePosition), transform.position) < 5f) {
			CameraControl.gamestart = true;
			print ("24351351");
			//TargetPosition = new Vector3 (19f, 0,-0.6f); 

		}
		
	}
}
