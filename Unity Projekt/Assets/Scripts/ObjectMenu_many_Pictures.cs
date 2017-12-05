using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ObjectMenu_many_Pictures : MonoBehaviour {

	public Canvas canvas;
	public Canvas PauseCanvas;
	public Transform Player;
	
	public Image image;
	public Sprite newCoverImage;
	
	public Button umdrehen;
	public Button next;
	public Button zurück;
	private int x;
	
	public Sprite[] imageList;
	
	
	void Start () 
	{
		Cursor.visible = false;
		x = -1;
		next.gameObject.SetActive(true);
	}
	
	void OnMouseDown()
	{
       Pause();
	   image.sprite = newCoverImage;
	}   

	
	
	public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false&&PauseCanvas.gameObject.activeInHierarchy == false)
        {
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
			next.gameObject.SetActive(false);
			umdrehen.gameObject.SetActive(false);
        }
    }
	
	public void nextPic()
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
	
	
}
