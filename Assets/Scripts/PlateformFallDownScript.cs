using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformFallDownScript : MonoBehaviour
{

	//Vars
	public float SecToFall = 0.5f;
	private Rigidbody rb;
	private Material plateformColor;
	private Vector3 startPosition;

	// Use this for initialization
	void Start ()
    {
		rb = GetComponent<Rigidbody>();
		startPosition = transform.position;
		plateformColor = GetComponent<Renderer> ().material;
	}

	void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "Player")
        {
			plateformColor.color = Color.red;
			StartCoroutine (FallDown ());
		}
        else if(other.gameObject.tag == "ZoneSpawn")
        {   //Entre dans le trigger de respawn
			//Réinit la plateforme
			plateformColor.color = Color.white;
			rb.isKinematic = true;
			transform.position = startPosition;
		}
	}


	//Coroutine pour délayer la chute de la plateforme
	IEnumerator FallDown()
    {
		yield return new WaitForSeconds (SecToFall);
		rb.isKinematic = false;
	}
}
