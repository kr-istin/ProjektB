using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hauptmenü_funktionen : MonoBehaviour {
	
	public int x;
	
	void Start () {
			
	}
	
	
	public void PlayGame(){
		x = PlayerPrefs.GetInt ("Remini");
		
		if(x == 0){
			SceneManager.LoadScene("Reminiscence");
		}else if(x == 1){
			SceneManager.LoadScene("House");
		} else{
			Debug.Log("Help");
		}
	
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