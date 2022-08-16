using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShurikenApi : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "Ninja")
        {
            
            if (collision.gameObject.name == "ObsApi")
            {

                collision.GetComponent<ObstacleFire>().dead(true);
               
            }

            Destroy(gameObject);
        }

        
    }
}
