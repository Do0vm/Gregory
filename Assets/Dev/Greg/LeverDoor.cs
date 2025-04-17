using System.Collections.Generic;
using UnityEngine;

public class DoorRevealInteraction : Interactive
{
    public GameObject hiddenDoor;


    private void Awake()
    {
        hiddenDoor.SetActive(false);

    }
    public override void OnInteraction()
    {
        if (hiddenDoor != null)
        {
            hiddenDoor.SetActive(true);
            hiddenDoor.tag = "Interactive";
            Debug.Log("Hidden door revealed with tag Door");
        }
    }
}