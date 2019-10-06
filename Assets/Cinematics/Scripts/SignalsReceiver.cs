using UnityEngine;

public class SignalsReceiver : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void UpdateAnimation(string trigger)
    {
        animator.SetTrigger(trigger);
    }

   
}
