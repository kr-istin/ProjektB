using System.Collections;
using UnityEngine;

public class InteractiveObject : MonoBehaviour {

	[SerializeField] private Vector3 openPosition, closedPosition;

	[SerializeField] private float animationTime;

	[SerializeField] private bool isOpen = false;

	private Hashtable iTweenArgs;

	void Start () {
		iTweenArgs = iTween.Hash ();
		iTweenArgs.Add ("position", openPosition);
		iTweenArgs.Add ("time", animationTime);
		iTweenArgs.Add ("islocal", true);
	}
	

	public void PerformAction () {
		if(Input.GetKeyDown(KeyCode.E)){
			if (isOpen) {
				iTweenArgs ["position"] = closedPosition;
			} else {
				iTweenArgs ["position"] = openPosition;
			}
			isOpen = !isOpen;

			iTween.MoveTo(gameObject, iTweenArgs);
		
		}
		
	}
}
