using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionPopUp : MonoBehaviour
{
    public GameObject OptionPopUpCanvas;

    // Start is called before the first frame update
    void Start()
    {
        OptionPopUpCanvas = GameObject.Find("Option_Popup_Canvas");
        OptionPopUpCanvas.SetActive(false);    
    }

    public void OptionPopUpSetActive(){
        OptionPopUpCanvas.SetActive(true);
    }

    public void OptionPopUpSetUnactive(){
        OptionPopUpCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
