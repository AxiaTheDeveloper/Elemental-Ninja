using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject PanelCtr;
    float pauseCtr;
    bool cek;
    [SerializeField] private Text ctr;
    // Start is called before the first frame update
    void Start()
    {
        Menu.gameObject.SetActive(false);
        ctr.gameObject.SetActive(false);
        PanelCtr.gameObject.SetActive(false);
        pauseCtr = 3f;
        cek = false;
    }

    private void Update()
    {
        if (cek == true)
        {
            pauseCtr -= 0.009f;
            
          
        }
        if(pauseCtr <= 0)
        {

            ctr.gameObject.SetActive(false);
            PanelCtr.gameObject.SetActive(false);
            Time.timeScale = 1f;
            cek = false;
            pauseCtr = 3f;
            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource adio in audios)
            {
                
                adio.mute = false;
                
            }
        }
        ctr.text = Mathf.Round(pauseCtr).ToString();
    }

    // Update is called once per frame
    public void Pause()
    {
        Menu.gameObject.SetActive(true);
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource adio in audios)
        {
            adio.mute = true;
            
        }
        Time.timeScale = 0f;
        
        
    }

    public void Unpause()
    {
        Menu.gameObject.SetActive(false);
        ctr.gameObject.SetActive(true);
        PanelCtr.gameObject.SetActive(true);
        cek = true;
        
    }

    public void Kembali()
    {

    }
}
