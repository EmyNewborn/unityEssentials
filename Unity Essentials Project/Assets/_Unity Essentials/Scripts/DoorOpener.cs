using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    Animator doorAnimator;


    void Start()
    {
        // Get the Animator component attached to the same GameObject as this script
        doorAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider Other)
    {
        // Check if the object entering the trigger is the player (or another specified object)
        if (Other.CompareTag("Player")) // Make sure the player GameObject has the tag "Player"
        {
            if (doorAnimator != null)
            {
                // Trigger the Door_Open animation
                doorAnimator.SetTrigger("Door_Open");
            }
        }
    }
}