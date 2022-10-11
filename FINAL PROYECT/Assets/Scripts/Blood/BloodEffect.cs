using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodEffect : MonoBehaviour
{

    public Image bloodEffectImage;

    private float r;
    private float g;
    private float b;
    private float a;
    private PlayerCollision playercollision;
    private PlayerData playerData;




    // Start is called before the first frame update
    void Start()
    {
        r = bloodEffectImage.color.r;
        g = bloodEffectImage.color.g;
        b = bloodEffectImage.color.b;
        a = bloodEffectImage.color.a;


        playercollision = GetComponent<PlayerCollision>();
        playerData = GetComponent<PlayerData>();



    }

    // Update is called once per frame
    void Update()
    {
          /*
        if ())
        {
            a += 0.01f;
        }*/

        a -= 0.01f;

        a = Mathf.Clamp(a, 0, 1f);

        ChangeColor();
    
    }

    private void ChangeColor()
    {
        Color c = new Color(r, g, b, a);
        bloodEffectImage.color = c;

    }
}
