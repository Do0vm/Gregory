using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    public InteractionType interactionType = InteractionType.PushButton;

    public GameObject door;
    public PlayerInventory playerInventory;

    public bool onlyOnce = true;

    [Header("Condition")] 
    public List<KeyItemData> requiredItems;

    public bool waitForObject;
    
    //Basic behaviour for Interactive objects is to trigger an animation
    //virtual makes the function changeable in children classes
    public virtual void OnInteraction()
    {
        //playerInventory != null &&

        if (playerInventory != null &&  playerInventory.HasKey(requiredItems))
        {

            door.SetActive(false);
            door.tag = "Interactive";
            Debug.Log("Golden key used. Door is now open.");
        }
        else
        {
            Debug.Log("Player does not have the required key.");
        }
    }

    
}
