using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTourniquetScript : MonoBehaviour
{

	public int Speed = 10;
	
	// Update is called once per frame
	void Update ()
    {
		transform.Rotate (Vector3.up * Speed * Time.deltaTime);
	}
}
