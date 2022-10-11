using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNew : MonoBehaviour
{

    public int rutina;
    public float cronometro;
    [SerializeField] Animator ani;
    public Quaternion angulo;
    public float grado;

    public GameObject target;
    public bool atacando;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        target = GameObject.Find("Link");
    }

    // Update is called once per frame
    void Update()
    {
        BehabiorEnemy();
    }

    public void BehabiorEnemy()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 5)
        {
            ani.SetBool("run", false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 0)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }

            switch (rutina)
            {
                case 0:
                    ani.SetBool("Walk", false);
                    break;

                case 1:
                    grado = Random.Range(0, 360);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;

                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                    transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                    ani.SetBool("walk", true);

                    break;
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, target.transform.position) > 1)
            {

            
            var lookpos = target.transform.position - transform.position;
            lookpos.y = 0;
            var rotation = Quaternion.LookRotation(lookpos);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3);
            ani.SetBool("walk", false);

            ani.SetBool("run", true);
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);

                ani.SetBool("attack", false);
             }
            else
            {
                ani.SetBool("walk", false);
                ani.SetBool("run", false);


                ani.SetBool("attack", false);
                atacando = true;

            }
        }

    }

    public void FinalAni()
    {
        ani.SetBool("Attack", false);
        atacando = false;
    }
}
