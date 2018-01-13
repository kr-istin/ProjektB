﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Menü_funktionen : MonoBehaviour {
	
	public Canvas canvas;
	public Canvas canvasPause;
	
	public Transform Player;
	
	public Button next;
	public Button zurück;
	public Button umdrehen;
	
	public Sprite rückseite;
	public Image image;
	
	public delegate void WeiterButtonClicked();
	public event WeiterButtonClicked weiterButtonClicked;
	

	
	void Start() {
	}
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
		weiterButtonClicked();
		Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false;
        canvasPause.gameObject.SetActive(false);
		canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
        Player.GetComponent<FirstPersonController>().enabled = true;
		zurück.gameObject.SetActive(false);
		next.gameObject.SetActive(false);
		umdrehen.gameObject.SetActive(false);
	}
	
	public void nextPic()
	{
		zurück.gameObject.SetActive(true);
	}
	/*
	public void beforePic(){
		x--;
		if(x==-1){
			picturelist.image.sprite = picturelist.newCoverImage;
			zurück.gameObject.SetActive(false);
			next.gameObject.SetActive(true);
		}else{
		picturelist.image.sprite = picturelist.imageList[x];
		}
	}
	
	public void turnAround(){
		if(y==true){
			image.sprite = newCoverImage;
		}
		if(y==false){
			image.sprite = rückseite;
		}
		y = !y;
	}*/
	
}