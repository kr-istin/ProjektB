using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour {

	/*public void  ModeSelect(){
		StartCoroutine("Wait");
	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(6);
		Application.LoadLevel("House");
	}*/
	void Start(){
		Invoke ("Load", 5);
	}


	void Load(){
		SceneManager.LoadScene ("House");
	}
}
