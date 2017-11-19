using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Pausemenü_funktionen : MonoBehaviour {

	
	public Canvas canvas;
	public Transform Player;
	void Start () 
	{
	
	}
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
	}
    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            Player.GetComponent<FirstPersonController>().enabled = false;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            Player.GetComponent<FirstPersonController>().enabled = true;
        }
    }
	  public void Quit()
    {
	#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
	#else
        Application.Quit ();
	#endif
    }
	public void Weiter()
	{
		if (canvas.gameObject.activeInHierarchy == true)
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            Player.GetComponent<FirstPersonController>().enabled = true;
        }
        else
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            Player.GetComponent<FirstPersonController>().enabled = false;
        }
	}
	
}