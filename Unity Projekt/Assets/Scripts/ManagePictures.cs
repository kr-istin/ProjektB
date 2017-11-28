using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ManagePictures : MonoBehaviour {
	
	public Canvas canvas;
	public Transform Player;
	
	public Image image;
	public Sprite newCoverImage;
	
	public Button next;
	//public Button zurück;
	
	public Sprite[] imageList;

	void Start () {
		next.gameObject.SetActive(true);
	}
	void OnMouseDown()
	{
		next.gameObject.SetActive(true);
		image.sprite = newCoverImage;
		Cursor.lockState = CursorLockMode.None; 
		Cursor.visible = true;
		canvas.gameObject.SetActive(true);
        Time.timeScale = 0;
        Player.GetComponent<FirstPersonController>().enabled = false;
	    
	}   
	/*public void nextPic()
	{
		x++;
		zurück.gameObject.SetActive(true);
		if(x==imageList.Length-1){
			next.gameObject.SetActive(false);
		}
		image.sprite = imageList[x];
		
	}
	
	public void beforePic(){
		x--;
		if(x==-1){
			image.sprite = newCoverImage;
			zurück.gameObject.SetActive(false);
			next.gameObject.SetActive(true);
		}
		image.sprite = imageList[x];
	}
	*/
}
