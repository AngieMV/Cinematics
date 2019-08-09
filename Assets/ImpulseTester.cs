using UnityEngine;
using Cinemachine;

public class ImpulseTester : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            GetComponent<CinemachineImpulseSource>().GenerateImpulse();
        }
    }

}
