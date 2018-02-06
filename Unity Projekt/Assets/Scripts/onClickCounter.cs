using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClickCounter : MonoBehaviour
{

    protected int[] counterArray;     // Array für die zu zählenden Objekte
    protected int arraySum;           // Variable zum zusammen Zählen der Array Werte


    void Start()
    {
        counterArray = new int[11];      // auf Anzahl der Objekte setzen
    }


    // Update is called once per frame
    void Update()
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
                    Debug.Log("Teddy wurde gezählt");
                }

                else if (hit.transform.tag == "storyEnvelopeClosed")
                {
                    counterArray[1] = 1;
                    Debug.Log("EnvelopeClosed wurde gezählt");
                }

                else if (hit.transform.tag == "storyLetter")
                {
                    counterArray[2] = 1;
                    Debug.Log("Letter wurde gezählt");
                }

                else if (hit.transform.tag == "storyBook")
                {
                    counterArray[3] = 1;
                    Debug.Log("Book wurde gezählt");
                }

                else if (hit.transform.tag == "storyNewspaper_Clipping")
                {
                    counterArray[4] = 1;
                    Debug.Log("Newspaper_Clipping wurde gezählt");
                }

                else if (hit.transform.tag == "storyBook_Joanna")
                {
                    counterArray[5] = 1;
                    Debug.Log("Book_Joanna wurde gezählt");
                }


                /**********************************************
               *   Badezimmer
               **********************************************/
                else if (hit.transform.tag == "storyPills")
                {
                    counterArray[6] = 1;
                    Debug.Log("Pills wurde gezählt");
                }


                /**********************************************
                *   Flur
                **********************************************/
                else if (hit.transform.tag == "storyTelephoneNote")
                {
                    counterArray[7] = 1;
                    Debug.Log("TelephoneNote wurde gezählt");
                }


                /**********************************************
                *   Küche
                **********************************************/
                else if (hit.transform.tag == "storyFridgeNote")
                {
                    counterArray[8] = 1;
                    Debug.Log("FridgeNote wurde gezählt");
                }

                else if (hit.transform.tag == "storyEltacoloco")
                {
                    counterArray[9] = 1;
                    Debug.Log("Eltacoloco wurde gezählt");
                }

                else if (hit.transform.tag == "storyHousepic")
                {
                    counterArray[10] = 1;
                    Debug.Log("Housepic wurde gezählt");
                }

            }

            for (int i = 0; i < counterArray.Length; i++)
            {
                arraySum += counterArray[i];
            }

            Debug.Log("Objekte: " + arraySum);
            arraySum = 0;           // zurücksetzen der Summe, da sie zum testen öfter ausgegeben wird

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

            Debug.Log("Summe:" + arraySum);
            arraySum = 0;
        }
    }
}
