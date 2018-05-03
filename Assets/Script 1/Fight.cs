using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour {

	public GameObject RH;

	public GameObject show1;
	public GameObject show2;
	public GameObject show3;
	public GameObject show4;
	public GameObject show5;
	public GameObject show6;
	public GameObject show7;
	public GameObject show8;

	public GameObject Hide1;
	public GameObject Hide2;
	public GameObject Hide3;
	public GameObject Hide4;
	public GameObject Hide5;
	public GameObject Hide6;
	public GameObject Hide7;
	public GameObject Hide8;

	public GameObject canvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) && (Vector2.Distance (Camera.main.ScreenToWorldPoint (Input.mousePosition), transform.position) < 1f)) {
			CameraControl.fight = true;
			canvas.SetActive (true);

			RH.SetActive (false);
			InvokeRepeating ("Toshow1", 1f, 6f);
			InvokeRepeating ("Toshow2", 1f, 7f);
			InvokeRepeating ("ToHide1", 1.5f, 3);
			InvokeRepeating ("ToHide2", 1.5f, 4f);

		}


		
	}

	void Toshow1(){

		show1.SetActive (true);
		show2.SetActive (true);
		show5.SetActive (true);
		show6.SetActive (true);




	}

	void Toshow2(){

		show3.SetActive (true);
		show4.SetActive (true);
		show7.SetActive (true);
		show8.SetActive (true);


	}



	void ToHide1(){
		Hide1.SetActive (false);
		Hide2.SetActive (false);
		Hide5.SetActive (false);
		Hide6.SetActive (false);



	}

	void ToHide2(){
		Hide3.SetActive (false);
		Hide4.SetActive (false);
		Hide7.SetActive (false);
		Hide8.SetActive (false);

	}









}
