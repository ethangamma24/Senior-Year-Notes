using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Replay : MonoBehaviour {
	 // Use this for initialization
	 void Start () {

	 }
	 // Update is called once per frame
	 void Update () {
		 if (Input.GetKeyDown("space")) {
        Application.LoadLevel("380 Final Project");
		 }
	 }
}
