using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour {


	public GameObject text;
	public GameObject text2;
	public GameObject text3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) && (Vector2.Distance (Camera.main.ScreenToWorldPoint (Input.mousePosition), transform.position) < 1f)) {

			text.SetActive (true);

			InvokeRepeating ("show", 1f, 10f);

		}
		
	}


	void show(){
		text2.SetActive (true);

		text3.SetActive (true);




		CancelInvoke ("show");
	}
}
