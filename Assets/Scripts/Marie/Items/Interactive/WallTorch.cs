using UnityEngine;
using UnityEngine.PlayerLoop;

public class WallTorch : Interactive
{
    public GameObject Chest;


    public static int litTorchCount = 0; 
    public static int requiredTorches = 3; 
    private bool isLit = false;

    public override void OnInteraction()
    {
        if (isLit) return;

        // we no longer need to look for child flames on a button
        isLit = true;
        litTorchCount++;

        if (litTorchCount >= requiredTorches)
        {
            Chest.SetActive(true);
        }
    }




}
