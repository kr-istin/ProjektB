using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Menü_Funktionen : MonoBehaviour {
	
	public Canvas canvasObject;
	public Canvas canvasPause;
	
	public Transform Player;
	
	public Button next;
	public Button before;
	
	public Image image;
	
	public delegate void WeiterButtonClicked();
	public event WeiterButtonClicked weiterButtonClicked;
	
	public delegate void NextButtonClicked();
	public event NextButtonClicked nextButtonClicked;
	
	public delegate void BeforeButtonClicked();
	public event BeforeButtonClicked beforeButtonClicked;
	
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
			canvasPause.gameObject.SetActive(true);
        }
	}
	
	public void Pause()
    {
		Cursor.lockState = CursorLockMode.None; 
        Cursor.visible = true;
        Time.timeScale = 0;
		Player.GetComponent<FirstPersonController>().enabled = false;
    }
	
	public void nextPic()
	{
		before.gameObject.SetActive(true);
		nextButtonClicked();
	}
	
	public void beforePic()
	{
		next.gameObject.SetActive(true);
		beforeButtonClicked();
	}

	public void Weiter()
	{
		weiterButtonClicked();
		Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false;
        canvasPause.gameObject.SetActive(false);
		canvasObject.gameObject.SetActive(false);
        Time.timeScale = 1;
        Player.GetComponent<FirstPersonController>().enabled = true;
		before.gameObject.SetActive(false);
		next.gameObject.SetActive(false);
	}
	
		public void Quit()
    {
	#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
	#else
        Application.Quit ();
	#endif
    }

}
