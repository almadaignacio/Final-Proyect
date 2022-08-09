using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 direction = new Vector3(0f,0f,1f);
    public float Speed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }

        Es lo mismo que decir :
        */

        if(Input.GetKey(KeyCode.W))
        {
            MovePLayer(Vector3.forward);
        }

        if(Input.GetKey(KeyCode.A))
        {
            MovePLayer(Vector3.left);
        }

        if(Input.GetKey(KeyCode.S))
        {
            MovePLayer(Vector3.back);
        }

        if(Input.GetKey(KeyCode.D))
        {
            MovePLayer(Vector3.right);
        }
    }

    private void MovePLayer(Vector3 direction) {
        transform.Translate(direction * Speed * Time.deltaTime);
    }
}
