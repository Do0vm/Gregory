using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    public InteractionType interactionType = InteractionType.PushButton;

    public GameObject door;
    //public PlayerInventory playerInventory;

    public bool onlyOnce = true;

    [Header("Condition")] 
    public List<KeyItemData> requiredItems;

    public bool waitForObject;

    //Basic behaviour for Interactive objects is to trigger an animation
    //virtual makes the function changeable in children classes
    public virtual void OnInteraction()
    {
        var inv = Inventory.Instance;

        bool keysOk =
                   (requiredItems == null || requiredItems.Count == 0) ||
                   (inv != null && inv.HasEveryItem(requiredItems));

        if (keysOk)
        {
            door.SetActive(false);
            Debug.Log($"{gameObject.name} opened!");
        }
        else
        {
            Debug.Log("Player does not have the required key.");
        }
    }


}
