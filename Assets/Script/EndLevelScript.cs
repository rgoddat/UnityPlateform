using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndLevelScript : MonoBehaviour {

	public string levelToLoad;
	public AudioClip soundWin;


	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			StartCoroutine (LoadNextLevel ());
		}
	}

	IEnumerator LoadNextLevel(){
		GetComponent<AudioSource> ().PlayOneShot (soundWin);
		yield return new WaitForSeconds (3f);
		SceneManager.LoadScene (levelToLoad);
	}
}
