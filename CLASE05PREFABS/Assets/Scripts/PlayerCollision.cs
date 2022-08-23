using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        //Debug.Log("ENTRANDO EN COLISION CON ->" + other.gameObject.name);
    }

    private void OnCollisionExit(Collision other) 
    {
        //Debug.Log("SALGO DE LA COLISION CON ->" + other.gameObject.name);
    }

    private void OnCollisionStay(Collision other) 
    {
       
        if(other.gameObject.name == "Portal")
        {
            Debug.Log("EL OBJETO " + other.gameObject.name + " CONTIENE 'Shrinker'");
        }
        else
        {
            Debug.Log("EN CONTACTO CON ->" + other.gameObject.name + ", EL OBJETO NO CONTIENE 'Shrinker'");
        }
    }
}
