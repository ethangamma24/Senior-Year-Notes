using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIManager : MonoBehaviour {
	 public MenuCam menuCam;
	 public GameObject NewGameButton;
	 public GameObject OptionsButton;
	 public GameObject ReturnToMenuBtn;
	 private UIScreen currentScreen;
	 // Use this for initialization
	 void Start () {
	  currentScreen = UIScreen.MainMenu;
	 }

	 // Update is called once per frame
	 void Update () {
	  //Enable buttons for main menu only
	  if(currentScreen == UIScreen.MainMenu)
	  {
	   NewGameButton.SetActive(true);
	   OptionsButton.SetActive(true);
	   ReturnToMenuBtn.SetActive(false);
	  }
	  else if(currentScreen == UIScreen.Options)
	  {
	   NewGameButton.SetActive(false);
	   OptionsButton.SetActive(false);
	   ReturnToMenuBtn.SetActive(true);

	  }

	 }
	 public void OptionsButtonClicked()
	 {

	  if (menuCam)
	  {
	   menuCam.OptionsScreen ();
	   currentScreen = UIScreen.Options;
	  }
	 }
	 public void MenuButtonClicked()
	 {

	  if (menuCam)
	  {
	   menuCam.MenuScreen ();
	   currentScreen = UIScreen.MainMenu;
	  }
	 }
	 public void NewGameButtonClicked()
	 {
	  Application.LoadLevel("380 Final Project");
	 }
	}
	public enum UIScreen
	{
	 MainMenu,
	 Options

	}
