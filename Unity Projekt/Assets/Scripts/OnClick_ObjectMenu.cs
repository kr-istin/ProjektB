using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class OnClick_ObjectMenu : MonoBehaviour {
	
	public Canvas canvas;
	public Transform Player;
	
	public Image image;
	public Sprite newCoverImage;
	
	//public Button umdrehen;
	//public Button next;
	//public Button zurück;
	//private int x;
	
	
	//public Sprite[] imageList;
	
	
	void Start () 
	{
		//x = 0;
		Cursor.visible = false;
		//Canvas canvas = GetComponent<Canvas>();
		//image.sprite = canvas.GetComponent<Sprite>();	
		/*if (imageList[0] != null){
			next.gameObject.SetActive(true);
			}*/
	}
	
	void OnMouseDown()
	{
       Pause();
	   image.sprite = newCoverImage;
	}   

	
	
	public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
			
			image.sprite = newCoverImage;
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
        }
    }
	
	void Update () 
	{
	}
	
	/*public void nextPic()
	{
		zurück.gameObject.SetActive(true);
		//image.sprite = newImage1;
		
		for(int i = x; i < imageList.Length ; i++){
			x=i;
			image.sprite = imageList[x];
		}
		
	}
	
	public void beforePic(){
		for(int i = x; i < imageList.Length ; i--){
			x=i;
			image.sprite = imageList[x];
		}
		
	}*/
	
	
}
