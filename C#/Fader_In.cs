﻿using UnityEngine;
using System.Collections;

public class Fader_In : MonoBehaviour {
	
	public GUITexture fadeWhite;

	// Use this for initialization
	void Start () {
		Rect currentRes = new Rect (-Screen.width * 0.5f, -Screen.height * 0.5f, Screen.width, Screen.height);
		guiTexture.pixelInset = currentRes;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void LetsBegin()
	{
		//Instantiate(fadeWhite);
		Application.LoadLevel("Island");
		
	}
}
