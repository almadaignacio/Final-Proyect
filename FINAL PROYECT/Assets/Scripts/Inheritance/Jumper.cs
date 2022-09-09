using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : BaseEnemy
{
    [SerializeField]
    [Range(1f, 100f)]
    private float jumpForce = 5f;

    private Rigidbody rbEnemy = null;

    private void Start()
    {
        rbEnemy = GetComponent<Rigidbody>();
        InvokeRepeating("JumpZombie", 0f, 2f);
    }


    private void JumpZombie()
    {
        Debug.Log("SALTADO");
        rbEnemy.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
