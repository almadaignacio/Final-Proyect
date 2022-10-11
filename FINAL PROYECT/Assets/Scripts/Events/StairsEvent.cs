using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StairsEvent : MonoBehaviour
{
    public UnityEvent OnTrigerButton3D;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("PLAYER INGRESANDO EN EL AREA");
            Destroy(other.gameObject);
            OnTrigerButton3D?.Invoke();

        }
    }
}
