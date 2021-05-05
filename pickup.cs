using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class pickup : MonoBehaviour
{
   public Collider col;
     public GameObject objToDestroy;
    public GameObject effect;

    void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.tag == "Player")
            Instantiate(effect, objToDestroy.transform.position, objToDestroy.transform.rotation);
          objToDestroy.SetActive(false);
           ScoreTextScript.coinAmount += 1;
           playerInfo.totalGold +=1;
            col.enabled=false;
           
    }

    void Update(){
        if(gameManager.playerdie == true){
           objToDestroy.SetActive(true);
           ScoreTextScript.coinAmount = 0;
               col.enabled=true;
        }

    } 
    
}