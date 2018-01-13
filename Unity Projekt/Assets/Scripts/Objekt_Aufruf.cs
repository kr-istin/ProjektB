using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Objekt_Aufruf : MonoBehaviour {
	
	public Canvas ObjectCanvas;
	public Canvas PauseCanvas;
	
	public Transform Player;
	
	public Image image;
	
	private int x = 0;
	
	public Button next;
	public Button before;
	
	public Sprite[] imageList;

	void OnMouseDown()
	{
		FindObjectOfType<Menü_Funktionen>().nextButtonClicked += NextPicture;	 
		FindObjectOfType<Menü_Funktionen>().weiterButtonClicked += WeiterButton;  
		FindObjectOfType<Menü_Funktionen>().beforeButtonClicked += BeforePicture;  
		
		if (ObjectCanvas.gameObject.activeInHierarchy == false&PauseCanvas.gameObject.activeInHierarchy == false){
			next.gameObject.SetActive(true);
			image.sprite = imageList[x];
			Cursor.lockState = CursorLockMode.None; 
			Cursor.visible = true;
			ObjectCanvas.gameObject.SetActive(true);
			Time.timeScale = 0;
			Player.GetComponent<FirstPersonController>().enabled = false;
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
		
		FindObjectOfType<Menü_Funktionen>().nextButtonClicked -= NextPicture;
		FindObjectOfType<Menü_Funktionen>().weiterButtonClicked -= WeiterButton;
		FindObjectOfType<Menü_Funktionen>().beforeButtonClicked -= BeforePicture;
	}
	
}
