using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingleLevel : MonoBehaviour
{
    private int currentStarsNum = 0;
    public int levelIndex;

    public void BackButton()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void StarsNumber(int _starsNum)
    {
        currentStarsNum = _starsNum;
        
        if(currentStarsNum > PlayerPrefs.GetInt("Lv" + levelIndex))
       {
            PlayerPrefs.SetInt("Lv" + levelIndex, _starsNum);
        }
        BackButton();
        Debug.Log(PlayerPrefs.GetInt("Lv" + levelIndex, _starsNum));
   }

}
