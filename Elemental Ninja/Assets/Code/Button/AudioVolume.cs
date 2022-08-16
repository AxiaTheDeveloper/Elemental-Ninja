using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolume : MonoBehaviour
{
    [SerializeField] private Slider slideVol;
    // Start is called before the first frame update
    
    
       
    public void Start()
    {
        if (PlayerPrefs.HasKey("saveVol") == false)
        {

            PlayerPrefs.SetFloat("saveVol", 0.5f);
            loadVol();
        }
        else
        {

            loadVol();
        }

    }
   

    // Update is called once per frame
    public void savechangeVol()
    {
        float nilaiVol = slideVol.value;
        PlayerPrefs.SetFloat("saveVol", nilaiVol);
        loadVol();
    }
    public void loadVol()
    {
        float nilaiVol = PlayerPrefs.GetFloat("saveVol");
        slideVol.value = nilaiVol;
        AudioListener.volume = nilaiVol;
    }
}
