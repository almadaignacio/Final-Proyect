using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{


   [SerializeField]
    [Range(0.2f, 10f)]
    private float speed = 2f;
    private float runDelay = 10f;

    //La enumeración no permite definir una estructura de tipos de elementos.
    enum ZombieTypes { Crawler, Stalker, Rioter };

    //Creamos entonces una propiedad del tipo de enumeración creada.
    [SerializeField] ZombieTypes zombieType;

    //Guardamos una referencia al transform del player para movernos en su dirección.
    [SerializeField] Transform playerTransform;

    [SerializeField] Animator enemyAnimator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        switch (zombieType)
        {
            case ZombieTypes.Crawler:
                MoveForward();
                break;
            case ZombieTypes.Stalker:
                Invoke("StalkerMove",runDelay);
                break;
            case ZombieTypes.Rioter:
                RotateAroundPlayer();
                break;
        }
    }

    void StalkerMove(){
        ChasePlayer();
        enemyAnimator.SetBool("IsRun", true);
    }

  private void RotateAroundPlayer()
    {
        // Puedo rotar antes de moverme para que el enemigo quede de frente al player (lo mire).
        LookPlayer();
        // Rotate Around permite "orbitar" al rededor de una posición.
        transform.RotateAround(playerTransform.position, Vector3.up, 5f * Time.deltaTime);
    }

    private void ChasePlayer()
    {
        LookPlayer();
        // Con la resta vectorial obtengo la dirección que me permite desplazarme hacia el player.
        Vector3 direction = (playerTransform.position - transform.position);
        // Uso la magnitude para avanzar solo hasta cierta distancia (y no superponer el enemigo)
        if (direction.magnitude > 2f)
        {
           // Uso normalized para trasformar el vector en un vector de magnitud uno (para avanzar de forma gradual y constante cada frame)
           transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    
    private void LookPlayer()
    {
        // Método para rotar "inmediatamente" hacia un trasform.
        //transform.LookAt(playerTransform);
        // Forma para rotar "gradualmente" hacia un trasform.
        Quaternion newRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1.5f * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        //SceneManager.GetActiveScene().buildIndex;
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Game Over");
        }

    }

    public void LoadGame(int index)
    {
        SceneManager.LoadScene("Game Over");
    }
    /*
        private void MoveForward()
        {
            LookPlayer();
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }

        private void ChasePlayer()
        {
            LookPlayer();
            Vector3 direction = (playerTransform.position - transform.position);
            if(direction.magnitude > 2f)
            {
            transform.position += direction.normalized * Speed * Time.deltaTime;;
            }
        }

        private void RotateAroundPlayer()
        {
            LookPlayer();
            transform.RotateAround(playerTransform.position, Vector3.up, 5f * Speed * Time.deltaTime);
        }

        private void LookPlayer()
        {
            Quaternion newRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1.5f * Time.deltaTime);
        }
    */

}
