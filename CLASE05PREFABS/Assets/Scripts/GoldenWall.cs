using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenWall : MonoBehaviour
{
   // public GameObject Wall;
    /*
    void Start() 
    {

    }

    void Update()
    {
        
    }
*/
    public Vector3 MinPosition;
    public Vector3 MaxPosition;
    public GameObject Wall;
    private float TimeInWall = 0;


     private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("ENTRANDO EN COLISION CON ->" + other.gameObject.name);
    }

    private void OnCollisionExit(Collision other) 
    {
        Debug.Log("SALGO DE LA COLISION CON ->" + other.gameObject.name);
    }

    private void OnCollisionStay(Collision other) 
    {
        Vector3 randomPosition = new Vector3(Random.Range(MinPosition.x,MaxPosition.x), Random.Range(2,2), Random.Range(MinPosition.z,MaxPosition.z));

        TimeInWall = 2f;
        TimeInWall += Time.deltaTime;

        Debug.Log("EN CONTACTO CON ->" + other.gameObject.name);
        if (TimeInWall >= 2f)
        {
            transform.rotation = Random.rotation;

            transform.position = randomPosition;

        }
        
    }


    
}
