using UnityEngine;

public class SignalsReceiver : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private float speed = 1;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void UpdateAnimation(string trigger)
    {
        animator.speed = speed;
        animator.SetTrigger(trigger);
    }

   
}
