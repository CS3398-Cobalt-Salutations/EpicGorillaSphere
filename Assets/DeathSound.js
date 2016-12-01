#pragma strict

var death : AudioClip;

function Start () {

}

function Update () {

}

function OnTriggerEnter () {

GetComponent(AudioSource).PlayOneShot(death, 4.0);

}