﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ObjectMenu_turn_around_2_Pictures : MonoBehaviour {

	
	public Canvas canvas;
	public Transform Player;
	
	public Image image;
	public Sprite newCoverImage;
	public Sprite rückseite;
	
	public Button umdrehen;
	public bool x;
	
	
	
	void Start () 
	{
		Cursor.visible = false;
		umdrehen.gameObject.SetActive(true);
	}
	
	void OnMouseDown()
	{
       if (canvas.gameObject.activeInHierarchy == false)
        {
			Cursor.lockState = CursorLockMode.None; 
            Cursor.visible = true;
			canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            Player.GetComponent<FirstPersonController>().enabled = false;
			
        }
	   image.sprite = newCoverImage;
	}   

	
		/*

	public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
			
			//image.sprite = newCoverImage;
			Cursor.lockState = CursorLockMode.None; 
            Cursor.visible = true;
			canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            Player.GetComponent<FirstPersonController>().enabled = false;
			
        }
    }
	public void PauseEnde()
    {
        if (canvas.gameObject.activeInHierarchy == true)
        {
			Cursor.visible = false;
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            Player.GetComponent<FirstPersonController>().enabled = true;
			umdrehen.gameObject.SetActive(false);
        }
    }*/
	public void turnAround(){
		if(x==true){
			image.sprite = newCoverImage;
		}
		if(x==false){
			image.sprite = rückseite;
		}
		x= !x;
	}
	
}