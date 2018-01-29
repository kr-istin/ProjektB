using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkForObjectMenu : MonoBehaviour {

    public GameObject teddy;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))        // 0 = left mouse button
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "1")
                {
                    Debug.Log("HIT");
                    teddy.GetComponent<Objekt_Aufruf>().OpenObjectMenu();
                }

                else
                {
                    Debug.Log("kein storyobject");
                }
            }
        }
    }
}
