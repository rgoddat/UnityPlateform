using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VieScript : MonoBehaviour {

	public float nbVies = 3;
	public Text txtVie;

	// Use this for initialization
	void Start () {
		txtVie.text = "Vies :" + (int) nbVies;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			nbVies -= 0.5f;
			txtVie.text = "Vies :" + (int) nbVies;

			if (nbVies == 0) {
				SceneManager.LoadScene (3);
			}
		}
	}
}
