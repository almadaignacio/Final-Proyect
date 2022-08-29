using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
  /*
    [SerializeField]
    [Range(0,10)]
    private float cooldown;

    private float TimeInPortal = 0;

    public bool Small;
    
    private void OnTriggerEnter(Collider other) 
    {
        //Debug.Log("ENTRANDO EN TRIGGER CON ->" + other.gameObject.name);

        TimeInPortal = 0;

        TimeInPortal += Time.deltaTime;
        
        if(Small == true) 
        {
            other.transform.localScale = gameObject.transform.localScale / 2;
            Small = false;
            Debug.Log("El objeto " + other.gameObject.name + " contiene 'Shrinker'");
        }
        else
        {
            other.transform.localScale = gameObject.transform.localScale * 1;
            Small = true;
            Debug.Log("El objeto " + other.gameObject.name + " contiene 'Shrinker'");
        }

    }

    private void OnTriggerExit(Collider other) 
    {   
        Debug.Log("El objeto " + other.gameObject.name + " contiene 'Shrinker'");
    }

    private void OnTriggerStay(Collider other) 
    {
        Debug.Log("El objeto " + other.gameObject.name + " contiene 'Shrinker'");
    }
*/

 private float cooldown = 2;

  private float TimeInPortal = 0;

  public bool iAlreadyShrink = false;



  private void Update()

  {



    TimeInPortal += Time.deltaTime;

  }



  private void OnTriggerEnter(Collider other) 

  {

    //Debug.Log("ENTRANDO EN TRIGGER CON ->" + other.gameObject.name);

     

    if(iAlreadyShrink == false) 

    {

      other.transform.localScale = gameObject.transform.localScale / 2;

      iAlreadyShrink = true;

      Debug.Log("El objeto " + other.gameObject.name + " contiene 'Shrinker'");

      TimeInPortal = 0;

    }

    else if (iAlreadyShrink == true && TimeInPortal >= cooldown)

    {

      other.transform.localScale = gameObject.transform.localScale * 2;

      iAlreadyShrink = false;

      Debug.Log("El objeto " + other.gameObject.name + " contiene 'Shrinker'");

    }

     

  }

}
