using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour {

	Vector3 TargetPosition;

	public static bool gamestart = false;
	public static bool Apple = false;
	public static bool moon = false;
	public static bool hunter = false;
	public static bool warning = false;
	public static bool fight = false;
	public static bool end = false;
	public static bool finalend = false;


	public GameObject CameraEND;

	public GameObject text01;
	public GameObject text02;
	public GameObject text03;
	public GameObject text04;
	public GameObject text05;



	public GameObject Dis01;
	public GameObject Dis02;
	public GameObject Dis03;
	public GameObject Dis04;
	public GameObject Dis05;
	public GameObject Dis06;
	public GameObject Dis07;

	public GameObject canvas;
	public static int Hit = 0;
	public Text HitScore;

	public AudioSource BGM;
	public AudioSource fightBGM;
	public AudioSource BGM2;



	// Use this for initialization
	void Start () {
		TargetPosition = transform.position;
		canvas.SetActive (false);
		fightBGM.Stop ();
		BGM2.Stop ();


	}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector3.MoveTowards (transform.position, TargetPosition,0.3f);
		if (gamestart == true) {
			TargetPosition = new Vector3 (19f, 0, -0.6f); 
			AniControl.walk = true;
			print ("AAAAAAAAAAAAAAa");
			gamestart = false;
		}

		if (Apple == true) {
			TargetPosition = new Vector3 (37f, 0, -0.6f); 
			//print ("AAAAAAAAAAAAAAa");
			Apple = false;
		}

		if (moon == true) {
			TargetPosition = new Vector3 (58f, 0, -0.6f); 
			//print ("AAAAAAAAAAAAAAa");
			moon = false;

		}

		if (hunter == true) {
			TargetPosition = new Vector3 (83f, 0, -0.6f);

			hunter = false;
		}

		if (warning == true) {
			TargetPosition = new Vector3 (87.5f, 0, -0.6f);

			warning = false;
		}


		if (fight == true) {
			TargetPosition = new Vector3 (89.32f, -10.79f, -0.6f);
			BGM.Stop ();
			fightBGM.Play ();

			fight = false;
		}

		if (Hit == 10) {
			TargetPosition = new Vector3 (109.67f, -10.79f, -0.6f);
			canvas.SetActive (false);
			BGM2.Play ();
			fightBGM.Stop ();
			Hit = 0;
		}

		if (end == true) {
			TargetPosition = new Vector3 (146f, -10.79f, -0.6f);


			end = false;


		}

		if (finalend == true) {
			TargetPosition = new Vector3 (169f, -10.79f, -0.6f);


			finalend = false;


		}










		if (CameraEND.transform.position == transform.position) {
			text01.SetActive (false);
			text02.SetActive (false);
			text03.SetActive (false);
			text04.SetActive (true);
			text05.SetActive (true);


			Destroy (Dis01);
			Destroy (Dis02);
			Destroy (Dis03);
			Destroy (Dis04);
			Destroy (Dis05);
			Destroy (Dis06);


		}


		HitScore.text = "HIT:" + Hit + "/10";





	}
}
