﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.ImageEffects;

public class Objekt_Aufruf : MonoBehaviour {
	
	public Canvas ObjectCanvas;
	public Canvas PauseCanvas;
	
	public Transform Player;
	
	public Image image;
	
	private int x = 0;
	
	public Button next;
	public Button before;
	
	public Sprite[] imageList;

    public GameObject mainCamera;

    void OnMouseDown()
	{
		FindObjectOfType<Menu>().nextButtonClicked += NextPicture;	 
		FindObjectOfType<Menu>().weiterButtonClicked += WeiterButton;  
		FindObjectOfType<Menu>().beforeButtonClicked += BeforePicture;  
		
		if (ObjectCanvas.gameObject.activeInHierarchy == false&PauseCanvas.gameObject.activeInHierarchy == false){
			next.gameObject.SetActive(true);
			image.sprite = imageList[x];
			Cursor.lockState = CursorLockMode.None; 
			Cursor.visible = true;
			ObjectCanvas.gameObject.SetActive(true);
			Time.timeScale = 0;
			Player.GetComponent<FirstPersonController>().enabled = false;
            mainCamera.GetComponent<BlurOptimized>().enabled = true; // activate blur
        }
	} 
	
	void NextPicture(){
		x++;
		
		Debug.Log("Hello" + x.ToString()) ;
		
		
		if(x==imageList.Length-1){
			next.gameObject.SetActive(false);
			image.sprite = imageList[x];
			}else{
				image.sprite = imageList[x];
			}
	}
	
	public void BeforePicture(){
	
		x--;	
		
		Debug.Log("Hello" + x.ToString()) ;
		if(x==0){
			image.sprite = imageList[x];
			before.gameObject.SetActive(false);
		}else{
			image.sprite = imageList[x];
		}
	}
	
	void WeiterButton(){
		
		FindObjectOfType<Menu>().nextButtonClicked -= NextPicture;
		FindObjectOfType<Menu>().weiterButtonClicked -= WeiterButton;
		FindObjectOfType<Menu>().beforeButtonClicked -= BeforePicture;
	}
	
}
