using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raft : MonoBehaviour
{

	void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "Player")
        {
			other.transform.SetParent (this.transform);
		}
	}
	
	// Update is called once per frame
	void OnTriggerExit (Collider other)
    {
		if (other.gameObject.tag == "Player")
        {
			other.transform.parent = null;
		}
	}
}
