using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonmoon : MonoBehaviour {

	public GameObject eat;
	public GameObject eat2;
	public GameObject eat3;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) && Vector2.Distance (Camera.main.ScreenToWorldPoint (Input.mousePosition), transform.position)<1f) {

			eat.SetActive (true);
			eat2.SetActive (false);
			eat3.SetActive (false);


		}

		
	}
}
