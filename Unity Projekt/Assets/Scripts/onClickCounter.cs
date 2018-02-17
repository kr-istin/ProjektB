using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClickCounter : MonoBehaviour
{

    protected int[] counterArray;     // Array für die zu zählenden Objekte
    protected int arraySum;           // Variable zum zusammen Zählen der Array Werte

    public GameObject upstrairsTrigger;
    public GameObject stairsTrigger;

    void Start()
    {
        counterArray = new int[13];      // auf Anzahl der Objekte setzen
        upstrairsTrigger.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))        // 0 = left mouse button
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                /**********************************************
                *   Wohnzimmer
                **********************************************/
                if (hit.transform.tag == "storyTeddy")
                {
                    counterArray[0] = 1;
                }

                else if (hit.transform.tag == "storyEnvelopeClosed")
                {
                    counterArray[1] = 1;
                }

                else if (hit.transform.tag == "storyLetter")
                {
                    counterArray[2] = 1;
                }

                else if (hit.transform.tag == "storyBook")
                {
                    counterArray[3] = 1;
                }

                else if (hit.transform.tag == "storyBook_Joanna")
                {
                    counterArray[5] = 1;
                }


                /**********************************************
               *   Badezimmer
               **********************************************/
                else if (hit.transform.tag == "storyPills")
                {
                    counterArray[6] = 1;
                }


                /**********************************************
                *   Flur
                **********************************************/
                else if (hit.transform.tag == "storyTelephoneNote")
                {
                    counterArray[7] = 1;
                }


                /**********************************************
                *   Küche
                **********************************************/
                else if (hit.transform.tag == "storyFridgeNote")
                {
                    counterArray[8] = 1;
                }

                else if (hit.transform.tag == "storyEltacoloco")
                {
                    counterArray[9] = 1;
                }

                else if (hit.transform.tag == "storyHousepic")
                {
                    counterArray[10] = 1;
                }


                /**********************************************
                *   Esszimmer
                **********************************************/
                else if (hit.transform.tag == "storyContract")
                {
                    counterArray[11] = 1;
                }

				else if (hit.transform.tag == "storyOpenBook")
				{
					counterArray[12] = 1;
				}

				else if (hit.transform.tag == "storyNewspaper_Clipping")
				{
					counterArray[4] = 1;
				}

            }

            /**********************************************
             * for testing purposes
             *  **********************************************/

            /*
            for (int i = 0; i < counterArray.Length; i++)
            {
                arraySum += counterArray[i];
            }

           Debug.Log("Objekte: " + arraySum);
            arraySum = 0;           // zurücksetzen der Summe, da sie zum testen öfter ausgegeben wird
            */
        }
    }


    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.tag == "stairsTrigger")
        {
            for (int i = 0; i < counterArray.Length; i++)
            {
                arraySum += counterArray[i];
            }

            if (arraySum >= 8)
            {
                //Debug.Log("genug Objekte, Summe:" + arraySum);
                arraySum = 0;
                upstrairsTrigger.gameObject.SetActive(true);
                Destroy(stairsTrigger);
            }

            else
            {
                //Debug.Log("Nicht genug Objekte, Summe:" + arraySum);
                arraySum = 0;
            }
               
        }

        if (trigger.tag == "goUpstairs")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            SceneManager.LoadScene("DemoThanks");
        }
    }


}
