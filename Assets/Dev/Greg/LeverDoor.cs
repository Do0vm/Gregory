using System.Collections.Generic;
using UnityEngine;

public class DoorRevealInteraction : Interactive
{
    public GameObject hiddenDoor;

    public override void OnInteraction()
    {
        if (hiddenDoor != null)
        {
            hiddenDoor.SetActive(true);
            hiddenDoor.tag = "Door";
            Debug.Log("Hidden door revealed with tag Door");
        }
    }
}