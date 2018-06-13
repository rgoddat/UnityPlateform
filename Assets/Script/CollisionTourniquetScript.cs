using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTourniquetScript : MonoBehaviour {

	public AudioClip soundDeath;
	private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
		spawnPoint = GameObject.Find ("SpawnPoint").GetComponent<Transform> ().position;
	}
	
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			GetComponent<AudioSource> ().PlayOneShot (soundDeath);
			other.gameObject.transform.position = spawnPoint;
		}
	}
}
