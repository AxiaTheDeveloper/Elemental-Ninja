using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionButton : MonoBehaviour
{
    [SerializeField] private GameObject OptionPanel;

    // Start is called before the first frame update
    void Start()
    {
        OptionPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buka()
    {
        OptionPanel.gameObject.SetActive(true);
    }
    
    public void tutup()
    {
        OptionPanel.gameObject.SetActive(false);
    }

}
