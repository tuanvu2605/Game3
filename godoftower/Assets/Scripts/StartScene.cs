using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

	public void StartGame()
	{
		TKSceneManager.ChangeScene ("Level1");
//		SceneManager.LoadScene ("Level1");
	}

	public void Continue()
	{
		
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
