using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	public GameObject corona;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var pos = transform.position;
		pos.y = corona.transform.position.y + 3;
		transform.position = pos;

		var pos2 = corona.transform.position;
		pos2.x = -0.18f;
		pos2.z = -2.16f;
		corona.transform.position = pos2;
		
	}
}
