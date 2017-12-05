using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEATH : MonoBehaviour {


  public GameObject Player;
  public Text DeathsText;
  public Text TimeText;
  public Text WinOrLose;
  public int Deaths;
  public float TheTime;
  public Vector3 temp;
  public static bool gameOver;

  void Start () {
      Player = GameObject.Find("FPSController");
      Deaths = 0;
      DeathsText.text = "Deaths: " + Deaths.ToString();
      TheTime = 45;
      TimeText.text = "Time: " + TheTime.ToString();
      WinOrLose.text = "";
      temp = Player.transform.rotation.eulerAngles;
      temp.y = 90.0f;
      gameOver = false;
  }

  // Update is called once per frame
  void FixedUpdate () {
    if (TheTime > 0) {
      TheTime -= Time.deltaTime;
      TimeText.text = "Time: " + Mathf.RoundToInt(TheTime).ToString();
    } else {
      TheTime = 0;
      TimeText.text = "Time: " + Mathf.RoundToInt(TheTime).ToString();
      SetGameOver();
    }
  }

	void OnCollisionEnter (Collision col) {
      //print("Collision detected with trigger object " + col.gameObject.name);
			if (col.gameObject.tag == "Maze") {
					Player.transform.position = new Vector3(0, 0, 0);
          Player.transform.eulerAngles = new Vector3(0, 90, 0);
          Deaths += 1;
          DeathsText.text = "Deaths: " + Deaths.ToString();
			}
      if (col.gameObject.tag == "Goal" && TheTime > 0) {
        Application.LoadLevel("Win Screen");
      } else if (col.gameObject.tag == "Goal" && TheTime <= 0) {
        Application.LoadLevel("Lose Screen");
      }
	}

  public static void SetGameOver () {
    gameOver = true;
    Application.LoadLevel("Lose Screen");
  }


}
