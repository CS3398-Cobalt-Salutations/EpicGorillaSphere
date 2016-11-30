#pragma strict

var victory : AudioClip;

function Start () {

}

function Update () {

}

function OnTriggerEnter() {

GetComponent(AudioSource).PlayOneShot(victory, 2.0);

}