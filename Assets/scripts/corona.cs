using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class corona : MonoBehaviour {

	public AudioSource som1;
	public AudioSource som2;

	public Text txtVidas;
	private static int vidas = 5;

	// Use this for initialization
	void Start () {
		
		txtVidas.text = "Life = " + vidas;

		som1 = GetComponents<AudioSource>()[0];
		som2 = GetComponents<AudioSource> () [1];
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		som1.Play ();

	}
	void OnTriggerEnter(Collider outro) {

		if (outro.gameObject.CompareTag ("vermelho")) {
			vidas--;
			txtVidas.text = "Life = " + vidas;

			som2.Play ();	
			InvokeRepeating ("perder", 0.5f, 1);

	}
}
	void perder() { 
		if (vidas < 1) {
			SceneManager.LoadScene ("gamover");
		} else {
			SceneManager.LoadScene ("coronajumper");
		}



}
}