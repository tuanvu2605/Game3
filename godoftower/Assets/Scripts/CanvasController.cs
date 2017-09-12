using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
public class CanvasController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePos = Input.mousePosition;
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

		Console.WriteLine ("Mouse Pos : ", mousePos);
		Console.WriteLine ("world Pos :", worldPos);
	}
}
