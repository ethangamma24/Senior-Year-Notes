﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCam : MonoBehaviour {
 public Transform MenuPos;
 public Transform OptionsPos;
 private float overTime = 1.5f;

 public void OptionsScreen()
 {
  StartCoroutine (MoveToOptions());

 }
 public void MenuScreen()
 {
  StartCoroutine (MoveToMenu());

 }
 private IEnumerator MoveToOptions()
 {

  Vector3 source = MenuPos.position;
  Vector3 target = OptionsPos.position;
  float startTime = Time.time;
  while(Time.time < startTime + overTime)
  {

   transform.position = Vector3.Lerp(source, target, (Time.time - startTime)/overTime);
   yield return new WaitForEndOfFrame();
  }
  transform.position = target;
 }

 private IEnumerator MoveToMenu()
 {
  Vector3 source = OptionsPos.position;
  Vector3 target = MenuPos.position;
  float startTime = Time.time;
  while(Time.time < startTime + overTime)
  {
   transform.position = Vector3.Lerp(source, target, (Time.time - startTime)/overTime);
   yield return new WaitForEndOfFrame();
  }
  transform.position = target;
 }

}
