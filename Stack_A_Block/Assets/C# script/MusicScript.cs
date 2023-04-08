using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicScript : MonoBehaviour
{
    public Slider VolumeSlider;
    public UserDataManager userdatamanager;
    public Toggle toggle;
    AudioSource backmusic;
    // Start is called before the first frame update
    void Start()
    {
        backmusic = this.GetComponent<AudioSource>();
        backmusic.Play();
        userdatamanager = GameObject.Find("ingamescript").GetComponent<UserDataManager>();
        backmusic.mute = userdatamanager.backgroundsound;
        if(userdatamanager.backgroundsound == false){
            toggle.isOn = false;
        }else{
            toggle.isOn = true;
        }
        VolumeSlider.value = 0.5f;
        backmusic.volume = VolumeSlider.value;
        DontDestroyOnLoad(backmusic);
    }

    public void toggleischanged(){
        if(toggle.isOn == true){    
            backmusic.mute = true;
        }else{
            backmusic.mute = false;
        }
    }
    public void sliderchanged(){
        backmusic.volume = VolumeSlider.value;
    }
    // Update is called once per frame

}
