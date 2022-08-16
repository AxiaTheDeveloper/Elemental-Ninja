using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChecker : MonoBehaviour
{
    public static LevelChecker statis;
    public Transform RespawnP;
    public GameObject Ninja;

    private void Awake()
    {
        statis = this;
    }

    public void Resp()
    {
        Ninja.transform.position = RespawnP.position;
        Ninja.transform.rotation = Quaternion.identity;
    }
}
