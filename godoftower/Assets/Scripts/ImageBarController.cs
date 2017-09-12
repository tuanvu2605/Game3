using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
public class ImageBarController : EventTrigger {

	Image image;


	private void Awake()
	{
		image = gameObject.GetComponent<Image> ();

	}


	// Use this for initialization
	public override void OnPointerEnter(PointerEventData eventData)
	{

		// Camera.main.ScreenToWorldPoint (Input.mousePosition);
		// transform.parent.InverseTransformPoint()
		Color tmpColor = image.color;
		tmpColor.a = 0;
		image.color = tmpColor;
	}
	public  override  void OnPointerExit(PointerEventData eventData)
	{
		Color tmpColor = image.color;
		tmpColor.a = 1;
		image.color = tmpColor;
		
	}

	void Update()
	{
		

		Vector3 mousePos = Input.mousePosition;
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

		Console.WriteLine ("Mouse Pos : ", mousePos);
		Console.WriteLine ("world Pos :", worldPos);


			
	}

}
