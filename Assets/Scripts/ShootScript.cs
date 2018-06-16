using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

	public GameObject PrefabProjectile;
	public float ShootRate = 0.5f;
	public int Speed = 2000;
	public AudioClip SoundShoot;

	private GameObject projectile;
	private float nextShoot;

	
	// Update is called once per frame
	void Update ()
    {
		if (Time.time > nextShoot)
        {
			nextShoot = Time.time + ShootRate;
			projectile = Instantiate (PrefabProjectile, transform.position, Quaternion.identity) as GameObject;
			GetComponent<AudioSource> ().PlayOneShot (SoundShoot);
			projectile.GetComponent<Rigidbody> ().AddForce (transform.TransformDirection(Vector3.right)* Speed);
			Destroy (projectile, 2f);
		}
	}
}
