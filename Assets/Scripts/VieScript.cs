using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VieScript : MonoBehaviour
{

	public float NbVies = 10;
	public Text TxtVie;

	// Use this for initialization
	void Start ()
    {
		TxtVie.text = "Vies :" + (int) NbVies;
	}

	void OnTriggerEnter (Collider other)
    {
		if (other.gameObject.tag == "Player")
        {
			NbVies -= 0.5f;
			TxtVie.text = "Vies :" + (int) NbVies;

			if (NbVies == 0)
            {
				SceneManager.LoadScene (3);
			}
		}
	}
}
