using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cakeslice
{
    public class OutlineManager : MonoBehaviour
    {

        public GameObject objectInside;
        // objectInside bezeichnet das Objekt, um dass der Trigger herum ist. 


        // Use this for initialization
        void Start()
        {
            //getScript = GameObject.Find(objectInside);
            objectInside.GetComponent<Outline>().enabled = false;
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            //Debug.Log("enter");
            objectInside.GetComponent<Outline>().enabled = true;

        }

        void OnTriggerExit(Collider other)
        {
            //Debug.Log("exit");
            objectInside.GetComponent<Outline>().enabled = false;
        }

    }
}
