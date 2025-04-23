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
        // true if no keys are required, or if the playerInventory exists AND HasKey(...) passes
        bool keysOk = (requiredItems == null || requiredItems.Count == 0)
                      || (playerInventory != null && playerInventory.HasKey(requiredItems));

        if (keysOk)
        {
            // open the door
            door.SetActive(false);
            Debug.Log($"{gameObject.name} opened!");
        }
        else
        {
            Debug.Log("Player does not have the required key.");
            // optionally trigger a fail animation here
        }
    }


}
