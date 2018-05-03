using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniControl : MonoBehaviour {

	public Animator myAnim;
	public static bool walk = false;

	public GameObject closewalk01;
	public GameObject closewalk02;
	public GameObject closewalk03;
	public GameObject closewalk04;
	public GameObject closewalk05;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {

		if (walk == true) {
			
			myAnim.SetBool ("walk", true);
		}

		if (Camera.main.transform.position == closewalk01.transform.position) {

			myAnim.SetBool ("walk", false);
		}

		if (Camera.main.transform.position == closewalk02.transform.position) {

			myAnim.SetBool ("walk", false);
		}

		if (Camera.main.transform.position == closewalk03.transform.position) {

			myAnim.SetBool ("walk", false);
		}

		if (Camera.main.transform.position == closewalk04.transform.position) {

			myAnim.SetBool ("walk", false);
		}

		if (Camera.main.transform.position == closewalk05.transform.position) {

			myAnim.SetBool ("walk", false);
		}


	}
}
