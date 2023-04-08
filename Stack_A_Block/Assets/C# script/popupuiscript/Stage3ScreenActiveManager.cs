using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Stage3ScreenActiveManager : MonoBehaviour
{
     public UserDataManager userdatamanager;
    public GameObject popup_UI;
    public GameObject star;
    public StageSet3 stageset;
    // Start is called before the first frame update
    void Start()
    {
        stageset = GameObject.Find("StageSetManager").GetComponent<StageSet3>();
        userdatamanager =GameObject.Find("ingamescript").GetComponent<UserDataManager>();
        CanvassetUnActive();
    }
    public void CanvassetActive(){
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        int stagenum = int.Parse(clickObject.name) - 2;
        if(clickObject.name == "1"){     
            star.GetComponent<SpriteRenderer>().sprite = stageset.star[stagenum + 1].GetComponent<Image>().sprite;
            popup_UI.SetActive(true);
        }
        else if(userdatamanager.Stage1[stagenum] == 0){
            Toastmanager.Instrance.showMessage(1f);
        }else{    
            popup_UI.SetActive(true);
            star.GetComponent<SpriteRenderer>().sprite = stageset.star[stagenum + 1].GetComponent<Image>().sprite;
        }
        
    }
    public void CanvassetUnActive(){
        popup_UI.SetActive(false);
    }
}
