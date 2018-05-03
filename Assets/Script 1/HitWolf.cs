using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWolf : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) && (Vector2.Distance (Camera.main.ScreenToWorldPoint (Input.mousePosition), transform.position) < 1f)) {

			CameraControl.Hit = CameraControl.Hit+1;


		}

		
	}
}
