using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RHFather : MonoBehaviour {

	public GameObject EndPosition;
	public GameObject C;
	public Transform father;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (C.transform.position == EndPosition.transform.position) {

			print ("asdasdh");

			transform.parent = father;


		}


	}
}
