using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public void stageSceneChange()
    {
        SceneManager.LoadScene("stage_select");
    }
    public void mainSceneChange()
    {
        SceneManager.LoadScene("main");
    }
}


