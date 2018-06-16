using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

	public AudioClip SoundDead;
	private Vector3 spawnPoint;

	// Use this for initialization
	void Start ()
    {
		spawnPoint = GameObject.Find ("SpawnPoint").GetComponent<Transform> ().position;
	}

	void OnTriggerEnter(Collider other)
    {
		
		if (other.gameObject.tag == "Player")
        {
			GetComponent<AudioSource> ().PlayOneShot (SoundDead);
			other.transform.position = spawnPoint;

		}
	}
}
