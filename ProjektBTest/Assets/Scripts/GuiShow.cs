using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiShow : MonoBehaviour {

	bool guiShow = false;
	[SerializeField] private Texture text;

	void start() {
		guiShow = true;
	}

	void update () {
		if(Input.GetKeyDown(KeyCode.E) && guiShow == true){
			//if(guiShow == true){
				GUI.DrawTexture(new Rect(10, 10, 60, 60), text, ScaleMode.ScaleToFit, true, 10.0F);
			}
		}

	}
