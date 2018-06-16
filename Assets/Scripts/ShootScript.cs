using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {

	public GameObject prefabProjectile;
	public float shootRate = 2f;
	public int speed = 1000;
	public AudioClip soundShoot;

	private GameObject projectile;
	private float nextShoot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextShoot) {
			nextShoot = Time.time + shootRate;
			projectile = Instantiate (prefabProjectile, transform.position, Quaternion.identity) as GameObject;
			GetComponent<AudioSource> ().PlayOneShot (soundShoot);
			projectile.GetComponent<Rigidbody> ().AddForce (transform.TransformDirection(Vector3.right)* speed);
			Destroy (projectile, 2f);
		}
	}
}
