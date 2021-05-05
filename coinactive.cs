using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;
public class coinactive : MonoBehaviour
{
 public GameObject Obj;  
    void Start()
    {
       Obj.SetActive(true);
    }

   void Update(){
  if(!gameManager.playerdie){
           Obj.SetActive(true);
           ScoreTextScript.coinAmount = 0;
        }
        }

    } 
