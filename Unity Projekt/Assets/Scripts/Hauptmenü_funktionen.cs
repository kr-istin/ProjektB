using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hauptmenü_funktionen : MonoBehaviour {
	
	public void PlayGame()
    {
        SceneManager.LoadScene("House");
    }

	public void EndGame(){
		//Application.Quit();
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit ();
		#endif
	}

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
	
	
}