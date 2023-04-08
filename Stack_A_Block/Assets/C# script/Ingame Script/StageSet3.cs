using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSet3 : MonoBehaviour
{
 public UserDataManager userdatamanager;
    // Start is called before the first frame update
    public GameObject[] stages;
    public GameObject[] star;
    public Sprite[] starlists;
    void Start()
    {   
        userdatamanager =GameObject.Find("ingamescript").GetComponent<UserDataManager>();
        for(int i = 0;i<24;i++){
            if(userdatamanager.Stage3[i] == 0){
                stages[i+1].GetComponent<Image>().color = new Color32(125,125,125,255);
            }else if(userdatamanager.Stage3[i] <= 30){
                star[i].GetComponent<Image>().sprite = starlists[0];
                stages[i+1].GetComponent<Image>().color = new Color32(255,255,255,255);
            }else if(userdatamanager.Stage3[i] <= 60 && userdatamanager.Stage3[i] > 30){
                star[i].GetComponent<Image>().sprite = starlists[1]; 
                stages[i+1].GetComponent<Image>().color = new Color32(255,255,255,255);
            }else if(userdatamanager.Stage3[i] <= 90 && userdatamanager.Stage3[i] > 60){
                star[i].GetComponent<Image>().sprite = starlists[3];  
                stages[i+1].GetComponent<Image>().color = new Color32(255,255,255,255);
            }
        }
            if(userdatamanager.Stage3[24] == 0){
            }
            else if(userdatamanager.Stage3[24] <= 30){
                star[24].GetComponent<Image>().sprite = starlists[0];
            }else if(userdatamanager.Stage3[24] <= 60 && userdatamanager.Stage3[24] > 30){
                star[24].GetComponent<Image>().sprite = starlists[1];
            }else if(userdatamanager.Stage3[24] <= 90 && userdatamanager.Stage3[24] > 60){
                star[24].GetComponent<Image>().sprite = starlists[3];
            }
    }

}
