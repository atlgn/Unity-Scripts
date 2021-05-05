using DG.Tweening;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject DoorGameObject;

    public bool DoorIsOpen;
    
    public void OpenDoor()
    {
        if (!DoorIsOpen)
        {
            //We use DoTween for smooth movement
            DoorGameObject.transform.DOLocalMoveY(5f, 1f).SetEase(Ease.OutBack);
            DoorIsOpen = true;
        }
    }

    public void CloseDoor()
    {
        if (DoorIsOpen)
        {
            DoorGameObject.transform.DOLocalMoveY(2f, 1f);
            DoorIsOpen = false;
        }
    }

    public void ToggleDoor()
    {
        if (DoorIsOpen)
        {
            CloseDoor();
        }
        else
        {
            OpenDoor();
        }
    }
}
