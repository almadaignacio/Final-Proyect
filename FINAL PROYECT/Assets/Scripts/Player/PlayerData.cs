using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField]
    [Range(0, 100)]
    private int live = 100;
    public int HP { get { return live; } }

    public void Healing(int value)
    {
        live += value;
        //DISPARAR EFECTO
        //DISPARAR SONIDO
    }

    public void Damage(int value)
    {
        live -= value;
    }
}
