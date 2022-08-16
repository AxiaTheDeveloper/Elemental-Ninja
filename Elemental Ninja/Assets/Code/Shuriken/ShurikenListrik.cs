using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenListrik : MonoBehaviour
{
    //[SerializeField] private AudioSource ancur;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "Ninja")
        {
            if (collision.gameObject.name == "ObsListrik")
            {
                
                collision.GetComponent<ObstacleListrik>().dead(true);
                
         
            }
            Destroy(gameObject);
        }


    }
}
