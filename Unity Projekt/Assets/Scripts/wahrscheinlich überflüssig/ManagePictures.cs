using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ManagePictures : MonoBehaviour {
	
	public Canvas canvas;
	public Canvas PauseCanvas;
	public Transform Player;
	
	public Image image;
	public Sprite newCoverImage;
	
	public Button next;
	//public Button zurück;
	
	public Sprite[] imageList;

	void OnMouseDown()
	{
		if (canvas.gameObject.activeInHierarchy == false&PauseCanvas.gameObject.activeInHierarchy == false){
			next.gameObject.SetActive(true);
			image.sprite = newCoverImage;
			Cursor.lockState = CursorLockMode.None; 
			Cursor.visible = true;
			canvas.gameObject.SetActive(true);
			Time.timeScale = 0;
			Player.GetComponent<FirstPersonController>().enabled = false;
		}
	    
	}   
	
}
