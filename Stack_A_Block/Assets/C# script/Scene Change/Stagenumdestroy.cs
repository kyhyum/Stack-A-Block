using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stagenumdestroy : MonoBehaviour
{
    public GameObject stagenum;
    void Start()
    {
        stagenum = GameObject.Find("Stagenum");
    }

    public void destroystagenum(){
        Destroy(stagenum);
    }

}
