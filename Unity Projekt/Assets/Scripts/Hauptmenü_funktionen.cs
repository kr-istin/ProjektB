using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hauptmenü_funktionen : MonoBehaviour {
	
	public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
	public void EndGame(){
		//Application.Quit();
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit ();
		#endif
    
	}
	
	
}