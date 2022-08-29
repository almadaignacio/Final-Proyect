using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    
    //public Vector3 direction = new Vector3(0f,0f,1f); // es lo mismo que Vector3.forward
    //public Vector3 BulletScale = new Vector3(2f,2f,2f);
    public float speed = 2f;
    public float LiveTime = 3f;
    public float Damage = 1f;


    // Start is called before the first frame update
    void Start()
    {
        //Invoke("DestroyDelay", LiveTime);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        //if(Input.GetKeyDown(KeyCode.Space)){
          //  Scale();
        //}
    }

    private void Move() {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); //+= direction * speed * Time.deltaTime;
    }

    //private void DestroyDelay()
    //{
      //  Destroy(gameObject);
    //}

    //private void Scale() {
          
      //  transform.localScale = BulletScale;
    //}
}
