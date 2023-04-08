using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ingamePopup : MonoBehaviour
{
    public GameObject pausePopupUI;
    public Timer timer;
    public void retrybutton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("timer").GetComponent<Timer>();
        PopupUIsetUnActive();
    }
    

    public void PopupUIsetActive(){
        timer.popUIstop();
        pausePopupUI.SetActive(true);
    }

    public void PopupUIsetUnActive(){
        timer.popUIcontinue();
        pausePopupUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
