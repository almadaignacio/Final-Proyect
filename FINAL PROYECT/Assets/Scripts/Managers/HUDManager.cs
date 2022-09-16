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
    private PlayerCollision Playercollision;
    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private Slider hpBar;
    [SerializeField] private GameObject winPanel;

    private void Awake()
    {
        Debug.Log("EJECUTANDO AWAKE");

        //Playercollision = GetComponent<PlayerCollision>();
        if (instance == null)
        {
            instance = this;
            Debug.Log(instance);
            PlayerCollision.Ondead += GameOver;
            PlayerCollision.OnChangeHP += SetHPBar;
            //PlayerCollision.Dying += Warning;
            PlayerEvent.OnWin += WinUI; 
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

    private void GameOver()
    {
        Debug.Log("RESPUESTA EN OTRO SCRIPT");
        GameOverPanel.SetActive(true);
    }
    /*
    private void Warning()
    {
        Debug.Log("RESPUESTA EN OTRO SCRIPT");
        WarningPanel.SetActive(true);
    }
    */

    private void WinUI()
    {
        winPanel.SetActive(true);
    }

    private void OnDisable()
    {
        PlayerCollision.Ondead -= GameOver; 
        PlayerCollision.OnChangeHP -= SetHPBar;
        PlayerEvent.OnWin -= WinUI;
    }
}
