using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hauptmenü_funktionen : MonoBehaviour {
	
	public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
	public void EndGame(){
		Application.Quit();
	}
	
	
}