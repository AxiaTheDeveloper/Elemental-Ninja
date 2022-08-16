using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LevelPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    public int leveltutorial, level1, level2;
    public bool booltutorial, bool1, bool2;
    void Start()
    {
        if (PlayerPrefs.HasKey("boolTutorial") == false)
        {
            PlayerPrefs.SetInt("boolTutorial", 1);
            PlayerPrefs.SetInt("LevelTutorial", 0);
            PlayerPrefs.SetInt("boollvl1", 0);
            PlayerPrefs.SetInt("Level1", 0);
            PlayerPrefs.SetInt("boollvl2", 0);
            PlayerPrefs.SetInt("Level2", 0);
            //loadLevel();
        }
        else
        {
            //loadLevel();
        }
    }



    //public void savechangeVol()
    //{
    //    float nilaiVol = slideVol.value;
    //    PlayerPrefs.SetFloat("saveVol", nilaiVol);
    //    loadVol();
    //}

    //public void loadLevel()
    //{
       // leveltutorial = PlayerPrefs.GetInt("LevelTutorial");
       // booltutorial = PlayerPrefs.GetInt("boolTutorial");
       // level1 = PlayerPrefs.GetInt("Level1");
       // bool1 = PlayerPrefs.GetInt("boollvl1");
        //level2 = PlayerPrefs.GetInt("Level2");
       // bool2 = PlayerPrefs.GetInt("boollvl2");

   //}
}

