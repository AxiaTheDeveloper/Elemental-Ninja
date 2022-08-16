using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SownManager : MonoBehaviour
{
    public static SownManager Instance { get; set; }
    public AudioSource Music;
    //public AudioClip clipMusic;

    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
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
    void Start()
    {
        
    }

    void Update()
    {
        
        if (SceneManager.GetActiveScene().name == "Level_1" || SceneManager.GetActiveScene().name == "Level_Tutorial" || SceneManager.GetActiveScene().name == "Level_2")
        {
            Destroy(gameObject);
            //Music.Stop();
            //Music.PlayOneShot(clipMusic);

            //Music.clip = clipMusic;

            //Music.Play();
        }
        

    }
    public void loadVol()
    {
        float nilaiVol = PlayerPrefs.GetFloat("saveVol");
        
        AudioListener.volume = nilaiVol;
    }
}
