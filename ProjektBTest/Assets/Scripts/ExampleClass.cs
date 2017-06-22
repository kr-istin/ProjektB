using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {


	public Texture aTexture;

	private bool enteredTrigger = false;

	void OnGui() {
		if (!aTexture) {
			Debug.LogError("Assign a Texture in the inspector.");
			return;
		}
		if(enteredTrigger == true && Input.GetKey(KeyCode.E)){
		GUI.DrawTexture(new Rect(10, 10, 60, 60), aTexture, ScaleMode.ScaleToFit, true, 10.0F);
		}
	}

	void  OnTriggerStay (Collider col)
	{
		if (col.tag == "Player")
		{
			enteredTrigger = true;
			Debug.Log ("hit");
		}
	}

	void  OnTriggerExit (Collider col)
	{
		if (col.tag == "Player")
		{
			enteredTrigger = false;
		}
	}
}