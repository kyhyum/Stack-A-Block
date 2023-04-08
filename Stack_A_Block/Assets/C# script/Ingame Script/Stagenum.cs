using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Stagenum : MonoBehaviour
{
    public int stagenum;
    // Start is called before the first frame update
    public void setStagenum(int btn_num){
        stagenum = btn_num;
    }
    public void Stagenumplus(){
        stagenum++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
