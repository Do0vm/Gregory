using UnityEngine;

public class GoldenKeyDoorInteraction : Interactive
{
    public GameObject door;
    public PlayerInventory playerInventory;

    public override void OnInteraction()
    {
        if (playerInventory != null && playerInventory.HasKey(requiredItems))
        {
            
            door.SetActive(true);
            door.tag = "Door";
            Debug.Log("Golden key used. Door is now open.");
        }
        else
        {
            Debug.Log("Player does not have the required key.");
        }
    }
}