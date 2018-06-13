using UnityEngine;
using System.Collections;

public class ScriptSpawn : MonoBehaviour {

	public AudioClip soundDead;
    
   	void OnTriggerEnter (Collider Other)
    {
        if(Other.gameObject.name== "FPSController")
        {
			GetComponent<AudioSource> ().PlayOneShot (soundDead);
            Other.gameObject.transform.position = GameObject.Find("SpawnPoint").transform.position;

            
        }	
	}		
}
