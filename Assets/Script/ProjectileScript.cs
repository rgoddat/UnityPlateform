using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

	public AudioClip soudDead;
	private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
		
		spawnPoint = GameObject.Find ("SpawnPoint").GetComponent<Transform> ().position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "Player") {
			GetComponent<AudioSource> ().PlayOneShot (soudDead);
			other.transform.position = spawnPoint;

		}
	}
}
