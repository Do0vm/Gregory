using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator animator;
    public bool canOpen = true; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canOpen)
        {
            animator.SetTrigger("Open");
        }
    }
}
