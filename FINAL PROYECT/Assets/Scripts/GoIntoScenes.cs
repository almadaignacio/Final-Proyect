using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoIntoScenes : MonoBehaviour
{
    public bool pasarNivel;
    public int IndiceNivel;

    public void CambiarNivel() 
    {
        SceneManager.LoadScene(IndiceNivel);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        CambiarNivel();
    }
}
