﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class displayUI : MonoBehaviour {

	public string myString;
	public Text myText;
	public float fadeTime;
	public bool displayInfo;

	// Use this for initialization
	void Start () {


		myText.color = Color.clear;
		//Cursor.visible = false;
		//Screen.lockCursor = true;
	}

	// Update is called once per frame
	void Update () 
	{

		FadeText ();

		/*if (Input.GetKeyDown (KeyCode.Escape)) 
         
                {
                        Screen.lockCursor = false;
                         
                }
                */


	}

	void OnTriggerEnter(Collider col)
	{
		displayInfo = true;

	}



	void OnTriggerExit(Collider col)

	{
		displayInfo = false;

	}


	void FadeText ()

	{


		if(displayInfo)
		{

			myText.text = myString;
			myText.color = Color.Lerp (myText.color, Color.white, fadeTime * Time.deltaTime);
		}

		else
		{

			myText.color = Color.Lerp (myText.color, Color.clear, fadeTime * Time.deltaTime);
		}




	}



}