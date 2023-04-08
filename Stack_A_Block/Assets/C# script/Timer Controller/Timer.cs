using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider timerSlider;
    public float gameTime;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public Sprite unfillstar;

    private bool stopTimer;
    private bool stop;
    private bool popupstop;

    public void timerstart(){
        stopTimer = false;
    }

    public int timerstop(){
        stopTimer =true;
        stop = true;
        return (int)Time.timeSinceLevelLoad;
    }

    public void popUIstop(){
        popupstop = true;
    }
    public void popUIcontinue(){
        popupstop = false;
    }
    public float timer(){
        float timex = gameTime - Time.timeSinceLevelLoad;
        return timex;
    }

    void Start()
    {
        popupstop = true;
        Time.timeScale = 0;
        stop = false;
        stopTimer = true;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        float time = gameTime - Time.timeSinceLevelLoad;
        
        Debug.Log(time);
        if(time <= 0){
            stopTimer = true;
        }


        if(stopTimer == false && popupstop == false){
            Time.timeScale = 1;
        }else if(stopTimer == false && popupstop == true){
            Time.timeScale = 0;
        }

        if(stopTimer == false){
            Time.timeScale = 1;
            timerSlider.value = time;
        }
        
        if(timerSlider.value < 60){
            star1.GetComponent<SpriteRenderer>().sprite = unfillstar;
        }
        if(timerSlider.value < 30){
            star2.GetComponent<SpriteRenderer>().sprite = unfillstar;
        }

        if(stop == true && stopTimer == true){
            timerSlider.value = timer();
            stop = false;
        }
    }
}
