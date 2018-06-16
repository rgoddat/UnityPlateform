using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

	public void Start()
    {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public void QuitGame()
    {
		
		Application.Quit ();

	}

	public void PlayGame()
    {
		SceneManager.LoadScene (1);
	}

}
