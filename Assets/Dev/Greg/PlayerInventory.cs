using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<KeyItemData> keys;

    public bool HasKey(List<KeyItemData> required)
    {
        foreach (var req in required)
        {
            if (!keys.Contains(req))
                return false;
        }
        return true;
    }
}
