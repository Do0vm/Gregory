using UnityEngine;

public class MultiButtonManager : MonoBehaviour
{
    public int totalRequiredButtons = 3;
    public GameObject doorToOpen;

    private int buttonsPressed = 0;

    public void ButtonPressed()
    {
        buttonsPressed++;

        if (buttonsPressed >= totalRequiredButtons && doorToOpen != null)
        {
            Debug.Log("All buttons pressed. Opening door.");
            doorToOpen.SetActive(false);
        }
    }
}
