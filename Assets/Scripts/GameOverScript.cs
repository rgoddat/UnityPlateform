using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{

	public float TimeToLoadMenu = 3f;

	// Use this for initialization
	void Start ()
    {
		StartCoroutine (LoadMenu());
	}
	
	IEnumerator LoadMenu()
    {
		yield return new WaitForSeconds (TimeToLoadMenu);
		SceneManager.LoadScene (0);
	}
}
