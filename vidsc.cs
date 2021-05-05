using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class vidsc : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    public GameObject text1;
    

  void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
      
    }
 public void Update()
    {  
    if (videoPlayer.isPlaying)
    {
        text1.SetActive(false);
      
       
    }else{
          text1.SetActive(true);

   
    }

    }

}