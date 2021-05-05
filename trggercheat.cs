using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class trggercheat : MonoBehaviour
{

    public GameObject triggers ;

    void Update()
    {  
      if (Input.GetKey(KeyCode.LeftShift))
{
    if (Input.GetKeyDown(KeyCode.F))
    {
        triggers.SetActive(false);
    }
}
 if (Input.GetKey(KeyCode.LeftShift))
{
    if (Input.GetKeyDown(KeyCode.G))
    {
        triggers.SetActive(true);
    }
}
 

if(Input.GetKey(KeyCode.LeftShift)){    
          if (Input.GetKeyDown(KeyCode.T)){
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    } }

    }}


