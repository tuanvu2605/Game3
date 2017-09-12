using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ImageDragController : EventTrigger {

	Image image;
	private bool mouseDown = false;
	private Vector3 startMousePos;
	private Vector3 startPos;

	private void Awake()
	{
		image = gameObject.GetComponent<Image> ();

	}



	public override void OnPointerDown(PointerEventData eventData)
	{
		mouseDown = true;
		startPos = image.transform.position;
		startMousePos = Input.mousePosition;
		Debug.Log("DOWN");
	}

	public override void OnPointerUp (PointerEventData eventData)
	{
		mouseDown = false;
		Debug.Log("UP");
	}




	
	// Update is called once per frame
	void Update () {
		if (mouseDown) {
			Vector3 currentPos = Input.mousePosition;
			Vector3 diff = currentPos - startMousePos;
			Vector3 pos = startPos + diff;
			image.transform.position = pos;

		}
		Vector3 posInParent = transform.parent.InverseTransformPoint (image.transform.position);



		if (posInParent.x < -(555/2)) {

			image.transform.position = new Vector3(0,image.transform.position.y,-10);
		}
		if (image.transform.position.x > 465) {

			image.transform.position = new Vector3(465 ,image.transform.position.y,-10);
		}
		//
		if(posInParent.y >  261)
		{
			image.transform.position = new Vector3(image.transform.position.x, 588 -36 ,-10);
		}
		else if(posInParent.y < -173)
		{
			image.transform.position = new Vector3(image.transform.position.x, 122 ,-10);
		}
	}
}
