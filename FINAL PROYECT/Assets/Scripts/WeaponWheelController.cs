using UnityEngine;
using UnityEngine.UI;

public class WeaponWheelController : MonoBehaviour
{
    public Animator anim;
    private bool WeaponSheelSelected = false;
    public Image SelectedItem;
    public Sprite noImage;
    public static int WeaponId;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            WeaponSheelSelected = !WeaponSheelSelected;
        }

        if (WeaponSheelSelected)
        {
            anim.SetBool("OpenWeaponWheel", true);
        }
        else
        {
            anim.SetBool("OpenWeaponWheel", false);
        }

        switch (WeaponId)
        {
            case 0:
                SelectedItem.sprite = noImage;
                break;
            case 1:
                Debug.Log("Basic Bow");
                break;
            case 2:
                Debug.Log("Medium Bow");
                break;
            case 3:
                Debug.Log("Epic Bow");
                break;

        }
    }
}
