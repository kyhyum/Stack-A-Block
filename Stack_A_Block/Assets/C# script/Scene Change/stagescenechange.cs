using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class stagescenechange : MonoBehaviour
{
    public void stage1SceneChange(){
        SceneManager.LoadScene("stage1");
    }
    public void stage2SceneChange(){
        SceneManager.LoadScene("stage2");
    }
    public void stage3SceneChange(){
        SceneManager.LoadScene("stage3");
    }


}