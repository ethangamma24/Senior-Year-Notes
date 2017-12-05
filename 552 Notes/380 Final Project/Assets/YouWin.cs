using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWin : MonoBehaviour {

  public Text WinOrLose;
	// Use this for initialization
	void Start () {
		WinOrLose.text = "";
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision col) {
      //print("Collision detected with trigger object " + col.gameObject.name);
			if (col.gameObject.tag == "Player") {
					DEATH.SetGameOver();
					WinOrLose.text = "YOU WIN!";
			}
	}
}
