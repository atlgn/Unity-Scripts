using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using UnityEngine.Events;

public class dotdorr : MonoBehaviour
{
    public bool IsPlayerInside;
    public GameObject LightObject;
    public GameObject Door;
    public bool DoorIsOpen;

    private void OnTriggerEnter(Collider other)
    {
       
         
        LightObject.SetActive(true);
        IsPlayerInside = true;   
       
    }

private void Update(){
      if(IsPlayerInside && Input.GetKeyDown(KeyCode.E)){
        if(DoorIsOpen){
            CloseDoor();
        }else
        {
            OpenDoor();
        }}
}

private void OnTriggerExit (Collider other){
 
 
    LightObject.SetActive(false);
    IsPlayerInside = false;
    
}

    
public void OpenDoor(){
    if(!DoorIsOpen){
        Door.transform.DOLocalMoveY(3,1f);
        DoorIsOpen =true;
    }
}

public void CloseDoor(){
    if(DoorIsOpen){}
    Door.transform.DOLocalMoveY(0,1f);
    DoorIsOpen= false;
}
}
