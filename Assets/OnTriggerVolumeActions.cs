using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class OnTriggerVolumeActions : MonoBehaviour
{

    [SerializeField]
    private UnityEvent _OnTriggerEnter;

    [SerializeField]
    private UnityEvent _OnTriggerExit;

    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        _OnTriggerEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        _OnTriggerExit.Invoke();
    }

}
