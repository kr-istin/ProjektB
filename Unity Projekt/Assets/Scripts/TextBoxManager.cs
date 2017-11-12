using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;
	public TextAsset textFile;

	//public string[] textLines;   --> Um einzelne Zeilen anzuzeigen, Array
	public string text;

	public int currentLine;
	public int endAtLine;

	public bool isActive;

	public AudioClip IvyErzaehlt;
	AudioSource audioSource;

	private float startTime;

	//public int extrazahl = 1;

	//public Collider col;

	void Start()
	{
		if (textFile != null)
		{
			//textLines = (textFile.text.Split('\n'));   --> nur um eine Zeile anzuzeigen
			text = textFile.text;						// der ganze Text wird angezeigt
			audioSource = GetComponent<AudioSource>();

		}

		/*if (endAtLine == 0)
		{
			endAtLine = textLines.Length - 1;
		}*/

		if (isActive) {
			EnableTextBox ();
		} 
		else 
		{
			DisableTextBox ();
		}
	}

	// Update is called once per frame
	void Update()
	{
		if (!isActive) 
		{
			return;
		}
			
		//theText.text = textLines [currentLine];
		theText.text = text;

		/*if (Input.GetKeyDown(KeyCode.Return))
		{
			currentLine += 1;
		}*/

		if (currentLine > endAtLine) 
		{
			DisableTextBox ();
		}

		/* Vielleicht kann ich das gebrauchen für Trigger etc..
		 
		// Ein Pilz wurde gesammelt -> Glückwunsch Text
		if (StatischeVariable.pilzAnzahl == 1 && extrazahl == 1)
		{
			//StatischeVariable.pilzAnzahl++; vorrübergehend ausgeblendet
			extrazahl++;
			textBox.SetActive(true);
			currentLine = 14;
			StartCoroutine(MyMethod());
		}

		// Alle 3 Pilze eingesammelt
		if (StatischeVariable.pilzAnzahl == 3)
		{
			textBox.SetActive(true);
			currentLine = 16;
			StatischeVariable.pilzAnzahl++;
			// theText.text = textLines[currentLine];
			// weiterButton.gameObject.SetActive(true);
			Weiter();
		}*/

	} 																// Update Ende
		
	public void EnableTextBox()
	{
		textBox.SetActive (true);
	}

	public void DisableTextBox()
	{
		textBox.SetActive (false);
	}
		
	public void OnTriggerEnter(Collider col)
	{
		StartCoroutine(timeCounter());
		isActive = true;
		textBox.SetActive (true);
		audioSource.PlayOneShot (IvyErzaehlt, 0.7f);
	}


	IEnumerator timeCounter() 
	{
		yield return new WaitForSeconds(8);
		textBox.SetActive(false);
		Destroy (gameObject);
		yield break;
	}
	


	/*
	public void Weiter()
	{
		weiterButton.gameObject.SetActive(true);
		theText.text = textLines[currentLine];
		currentLine += 1;
	
		if (currentLine == 10)
		{
			jaButton.gameObject.SetActive(true);
			neinButton.gameObject.SetActive(true);
			//textBox.SetActive(false);
			weiterButton.gameObject.SetActive(false);

		}

		//Ende 1. Abschnitt Eule redet - Eulenschrei - Pilze freigeschaltet
		if (currentLine == 14)
		{
			audioSource.PlayOneShot(eulenschrei, 0.7f);
			demoPilz.SetActive(false);
			pilz.SetActive(true);
			textBox.SetActive(false);
			weiterButton.gameObject.SetActive(false);
		}

		if (currentLine == 19)
		{
			textBox.SetActive(false);
			weiterButton.gameObject.SetActive(false);
		}

	}
	public void Ja()
	{
		neinButton.gameObject.SetActive(false);
		theText.text = textLines[currentLine];
		currentLine += 1;
		Weiter();


	}*/



}