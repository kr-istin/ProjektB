using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class MangagePictures : MonoBehaviour {
	public Image image;
	public Sprite newCoverImage;
	
	public Button umdrehen;
	public Button next;
	public Button zurück;
	private int x;
	
	public Sprite[] imageList;
	// Use this for initialization
	void Start () {
		x = -1;
		next.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
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
