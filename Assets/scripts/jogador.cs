using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		transform.RotateAround (new Vector3 (0, 0, 0), Vector3.up, h * 3);
		
	}
}
