using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

	public float timeToLoadMenu = 3f;

	// Use this for initialization
	void Start () {
		StartCoroutine (LoadMenu());
	}
	
	IEnumerator LoadMenu(){
		yield return new WaitForSeconds (timeToLoadMenu);
		SceneManager.LoadScene (0);
	}
}
