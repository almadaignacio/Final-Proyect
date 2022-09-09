using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HUDManager : MonoBehaviour
{
    private static HUDManager instance;
    public static HUDManager Instance { get => instance; }

    //[SerializeField] private Text selectedText;
    //[SerializeField] private GameObject weaponPanel;
    //[SerializeField] private GameObject buyPanel;
    [SerializeField] private Slider hpBar;

    private void Awake()
    {
        Debug.Log("EJECUTANDO AWAKE");
        if (instance == null)
        {
            instance = this;
            Debug.Log(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void SetHPBar(int newValue)
    {
        instance.hpBar.value = newValue;
    }
}
