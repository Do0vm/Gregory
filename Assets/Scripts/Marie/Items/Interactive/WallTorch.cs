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




        //If I want to do the base OnInteraction anyway first
        //base.OnInteraction();
        //Activate light and fire
        if (isLit) return;

        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);

        isLit = true;
        litTorchCount++;

        if (litTorchCount >= requiredTorches)
        {
            Chest.SetActive(true);
        }


    }
    


}
