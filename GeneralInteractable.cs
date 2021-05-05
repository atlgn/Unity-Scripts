using UnityEngine;
using UnityEngine.Events;


public class GeneralInteractable : MonoBehaviour
{
    
    public bool IsPlayerInside;
    public UnityEvent OnInteractedOR;
    public UnityEvent OnInteracted;
   
    public UnityEvent OnPlayerEnter;

    public UnityEvent OnPlayerExit;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IsPlayerInside = true;
            OnPlayerEnter.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IsPlayerInside = false;
            OnPlayerExit.Invoke();
        }
    }

    private void Update()
    {
        // if the player is inside AND when i press E it opens the door
        if (IsPlayerInside && Input.GetKeyDown(KeyCode.E))
        {
            OnInteracted.Invoke();
        }
      
        
    } 

private void iteractor(){

   if (Input.GetKeyDown(KeyCode.E))   
     
OnInteractedOR.Invoke();

   
  }



}
