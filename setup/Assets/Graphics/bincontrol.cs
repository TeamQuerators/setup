using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bincontrol : MonoBehaviour {

	public Transform bottomObj;
	public Transform topObj;
	public Transform spagObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown()
	{
		if (gameObject.name == "plate bin") 
		{
			Instantiate (bottomObj, new Vector2 (0, -.5f), bottomObj.rotation);
			Instantiate (topObj, new Vector2 (0, -.3f), topObj.rotation);

		}
	}

}
