using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMenuController : MonoBehaviour {

    public GameObject gameControl;

    void Start()
    {
        gameControl.GetComponent<checkForObjectMenu>().enabled = false;
    }
    	
	void OnTriggerEnter(Collider col)
    {
        gameControl.GetComponent<checkForObjectMenu>().enabled = true;
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag != "ignoreTrigger")
        {
            gameControl.GetComponent<checkForObjectMenu>().enabled = false;
        }
    }
}
