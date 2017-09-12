using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class GateKeeper : MonoBehaviour {

	public string levelPassword;
	public string nextLevelName;
	public GameObject accessDeniedText;
	public InputField passwordInputField;
	public RectTransform panel;



	public void OnPasswordSubmit()
	{
		if (passwordInputField.text != levelPassword) 
		{
			accessDeniedText.SetActive (true);
			passwordInputField.text = "";
		}

		if (passwordInputField.text == levelPassword) 
		{
			TKSceneManager.ChangeScene (nextLevelName);
		}


	}

	public void PointerEnter()
	{

	}

	public void PointerDown()
	{
		
	}

	public void PointerUp(){
	

	}



}
