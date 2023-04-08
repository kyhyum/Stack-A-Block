using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    [SerializeField] GameObject[] stageArray;
    GameObject currentStage;
    Stagenum getstagenum;
    // Start is called before the first frame update
    public void SettingStage(int stagenum){
        currentStage = Instantiate(stageArray[stagenum],this.transform);
    }
    void Start()
    {
        getstagenum = GameObject.Find("Stagenum").GetComponent<Stagenum>();
        SettingStage(getstagenum.stagenum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
