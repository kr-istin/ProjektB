using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuchCollider : MonoBehaviour {

	public GameObject otherGameObject;
	public Collider coll;

	private TextBoxManager textBoxManager;

	void Awake ()
	{
		textBoxManager = GetComponent<TextBoxManager> ();
	}


	public void OnTriggerEnter(Collider coll)
	{
		textBoxManager.EnableTextBox ();
	}

}
