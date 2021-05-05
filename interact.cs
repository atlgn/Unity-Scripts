using UnityEngine;
using UnityEngine.Events;


public class interact : MonoBehaviour
{
    
    private bool IsPlayerInside;
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
     
        if (IsPlayerInside && Input.GetKeyDown(KeyCode.E))
        {
            OnInteracted.Invoke();
        }
    }
}