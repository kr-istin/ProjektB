using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.ImageEffects;

public class checkForObjectMenu : MonoBehaviour {

    /// <summary>
    ///     alle Story Objekte als GameObjekt
    ///     (damit andere Skripte auf diese zugreifen können)
    /// </summary>

    // Wohnzimmer
    public GameObject teddy;
    public GameObject envelopeClosed;
    public GameObject letter;
	public GameObject bookDepression;
	public GameObject bookJoanna;

    // Badezimmer
    public GameObject pills;

    // Flur
    public GameObject telephoneNote;

    // Küche
    public GameObject fridgenote;
    public GameObject housepic;
    public GameObject eltacoloco;

	//Esszimmer
	public GameObject openbook;
    public GameObject contract;
	public GameObject newspaperClipping;


    void FixedUpdate () {
        if (Input.GetMouseButtonDown(0))        // 0 = left mouse button
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                Debug.Log("check for object menu raycast hit");

                /**********************************************
                *   Wohnzimmer
                **********************************************/
                if (hit.transform.tag == "storyTeddy")
                {
                    teddy.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
                }

                else if (hit.transform.tag == "storyEnvelopeClosed")
                {
                    envelopeClosed.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
                }

                else if (hit.transform.tag == "storyLetter")
                {
                    letter.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
                }

				else if (hit.transform.tag == "storyBook")
				{
					bookDepression.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
				}

				else if (hit.transform.tag == "storyBook_Joanna")
				{
					bookJoanna.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
				}

                /**********************************************
                *   Badezimmer
                **********************************************/
                else if(hit.transform.tag == "storyPills")
                {
                    pills.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
                }


                /**********************************************
                *   Flur
                **********************************************/
                else if (hit.transform.tag == "storyTelephoneNote")
                {
                    telephoneNote.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
                }

                /**********************************************
                *   Küche
                **********************************************/
                else if (hit.transform.tag == "storyFridgeNote")
                {
                    fridgenote.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
                }

                else if (hit.transform.tag == "storyEltacoloco")
                {
                    eltacoloco.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
                }

                else if (hit.transform.tag == "storyHousepic")
                {
                    housepic.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
                }

				/**********************************************
                *   Esszimmer
                **********************************************/
				else if (hit.transform.tag == "storyOpenBook")
				{
					openbook.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
				}

                else if (hit.transform.tag == "storyContract")
                {
                    contract.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
                }

				else if (hit.transform.tag == "storyNewspaper_Clipping")
				{
					newspaperClipping.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
				}

            }
        }
    }
}
