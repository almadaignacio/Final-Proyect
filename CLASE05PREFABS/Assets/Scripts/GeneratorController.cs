using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{ 
    public GameObject enemyPrefab;
    public float DelaySpawn = 3f;
    public float InternalSpawn = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparo", DelaySpawn, InternalSpawn);     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Disparo() 
    {
        Instantiate(enemyPrefab);
    }
}
