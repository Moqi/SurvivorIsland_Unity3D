﻿#pragma strict

var levelToLoad : String;
var normalTexture : Texture2D;
var rollOverTexture : Texture2D;
var beep : AudioClip;

function Start () {

}

function Update () {

}

function OnMouseEnter()
{
 guiTexture.texture = rollOverTexture;
}

function OnMouseExit()
{
 guiTexture.texture = normalTexture;
}

function OnMouseUp()
{
	audio.PlayOneShot(beep);
	yield new WaitForSeconds (0.35);
	Application.LoadLevel(levelToLoad);
}

@script RequireComponent(AudioSource);