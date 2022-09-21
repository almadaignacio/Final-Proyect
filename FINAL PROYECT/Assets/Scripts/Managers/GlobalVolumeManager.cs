using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GlobalVolumeManager : MonoBehaviour
{
    private PostProcessVolume globalVolumen;

    [SerializeField]
    bool isDamageFilter = false;

    // Start is called before the first frame update
    void Start()
    {
        globalVolumen = GetComponent<PostProcessVolume>();
        OnDamageFilter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDamageFilter()
    {
        ColorGrading colorFX;
        if(globalVolumen.profile.TryGetSettings(out colorFX))
        {
            colorFX.active = isDamageFilter;
        }
    }
}
