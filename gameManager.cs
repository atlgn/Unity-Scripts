using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Events;
public class gameManager : MonoBehaviour

{
public Transform baseSpawn;
    public GameObject finishscreen;
      public GameObject dscreen;
      public GameObject resandexit;
    public bool diedscreen = false ;
    private int rangenum ;
    public Transform player;
    public Transform RespawnPoint;
    public AudioSource screem1;
  public AudioSource screem2;
  public GameObject usetext;

public FirstPersonController control ;
public playerInfo playerInfo;
  public static bool playerdie ;
    public GameObject Dscreen { get => dscreen; set => dscreen = value; }

void Start(){
    
    Dscreen.SetActive(false);
    playerdie = false ;
 
}

    void Update(){
    if (diedscreen == true)
    {
         
        Dscreen.SetActive(true);
        
    }
    else{
        Dscreen.SetActive(false);
    }
    }

     public void EndGame(){
  
   if (diedscreen == false) // died screen
              Debug.Log("Game Over");
                {
                   
                    respawnPostion();
                    playScreem();
                    control.enabled = false;//char control enable false 
                     diedscreen = true;
                    playerdie = true;
                     
                  
                  
                }
    }
public void respawnPostion(){
    player.position = RespawnPoint.position;
}
public void respawnPlayer(){
Debug.Log("respawn");
diedscreen = false ;
 control.enabled = true;
 playerInfo.currenthealth = playerInfo.maxHealth;
 playerInfo.healthBar.value = playerInfo.currenthealth;
  playerdie = false;
 
}

   public void doExitGame() {
     Application.Quit();
     Debug.Log("quited");
 }


public void playScreem(){
    rangenum= Random.Range(0,6);
    if (rangenum <= 3 )
    {
        screem1.Play();
       
    }else{
        screem2.Play();
       
    }

}

public void usee(){
usetext.SetActive(true);

}
public void useexit(){
    usetext.SetActive(false);
}

public void transfer(){
     control.enabled = false;
      respawnPostion();
      StartCoroutine(waitForGO());
      
}
IEnumerator waitForGO(){
      yield return new WaitForSeconds(2);
      control.enabled = true;
}


public void finish(){
finishscreen.SetActive(true);
control.enabled=false;
}
public void controldisable(){
    control.enabled = false;
}
public void controlenable(){
    control.enabled = true;
}
public void mainSpawn(){
    player.position = baseSpawn.position;
}
}