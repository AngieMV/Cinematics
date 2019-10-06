using UnityEngine;

public class MonstersSignalsReceiver : MonoBehaviour
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
