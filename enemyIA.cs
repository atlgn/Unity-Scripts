 using UnityEngine;
 using System.Collections;
using System.Collections.Generic;
 public class enemyIA : MonoBehaviour  {
 
  public GameObject[] waypoints;
    public Transform player;
    int current = 0;
    public float speed;
    public float playerfollowspeed;
    public bool playerarea =false;
    public bool followplayer =false;
	
	void Update () {
        if(playerarea == false && followplayer == false){
		if(Vector3.Distance(waypoints[current].transform.position, transform.position) <1)
        {
            current = Random.Range(0,waypoints.Length);
            if (current >= waypoints.Length)
            {
                current = 0;
            }

        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
        }
        else{
  transform.position = Vector3.MoveTowards(transform.position, player.position, playerfollowspeed);
        }
    }

    public void enterareaplayer(){
               playerarea= true;
          followplayer =true;
        
    
    }
    public void outareaplayer(){
         playerarea= false ; 
             followplayer = false ;
         }
    }
