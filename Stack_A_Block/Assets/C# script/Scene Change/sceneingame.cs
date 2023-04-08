using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneingame : MonoBehaviour
{
    public StageManager stagemanager;
    public GameObject stagenum;
    public void stage1_gameSceneChange(){
        SceneManager.LoadScene("stage1_game");
        DontDestroyOnLoad(stagenum);
    }
    public void stage2_gameSceneChange(){
        SceneManager.LoadScene("stage2_game");
         DontDestroyOnLoad(stagenum);
    }
    public void stage3_gameSceneChange(){
        SceneManager.LoadScene("stage3_game");
         DontDestroyOnLoad(stagenum);
    }
    // Start is called before the first frame update
    void Start()
    {
        stagenum = GameObject.Find("Stagenum");
    }
    // Update is called once per frame
    void Update()
    {
    }
}
