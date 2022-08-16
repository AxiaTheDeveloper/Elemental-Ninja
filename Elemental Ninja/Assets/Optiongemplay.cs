using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Optiongemplay : MonoBehaviour
{
    public void optiongem()
    {
        SceneManager.LoadScene("Options");
    }
    public void Backgemplay()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
