using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {

	[SerializeField] private float interactRange;

	private InteractiveObject interactiveObject;
	//private GuiShow guiShow; //neu
	private Camera cam;
	private RaycastHit hit;

	void Start (){
		cam = Camera.main;
	}
		
	void Update () {
		if(Input.GetKeyDown(KeyCode.E)) {
			Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, interactRange);
			if(hit.transform){
				interactiveObject = hit.transform.GetComponent<InteractiveObject>();
				//interactiveObject = hit.transform.GetComponent<GuiShow>(); // neu
				}
		}
			if (interactiveObject){
				interactiveObject.PerformAction();
			}
			/*if (guiShow) {
			guiShow.PerformAction();
			}*/
	}
}
