using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameclearpopup : MonoBehaviour
{
    public UserDataManager userdatamanager;
    public Stagenum getstagenum;
    public GameObject GameClearpopup;
    public GameObject GameClearpopup_star;
    public Sprite[] starlists;

    public void Stagenumplus(){
        getstagenum.stagenum++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Start is called before the first frame update
    void Start()
    {
        GameClearpopup_star = GameObject.Find("gameclearStar");
        userdatamanager =GameObject.Find("ingamescript").GetComponent<UserDataManager>();
        GameClearpopup = GameObject.Find("popupGameClearCanvas");
        getstagenum = GameObject.Find("Stagenum").GetComponent<Stagenum>();
        GameClearpopup_star = GameObject.Find("gameclearStar");
        GameClearpopup.SetActive(false);
        if(userdatamanager.Stage1[getstagenum.stagenum] <= 30){
                GameClearpopup_star.GetComponent<SpriteRenderer>().sprite = starlists[0];
            }else if(userdatamanager.Stage1[getstagenum.stagenum] <= 60 && userdatamanager.Stage1[getstagenum.stagenum] > 30){
                GameClearpopup_star.GetComponent<SpriteRenderer>().sprite = starlists[1]; 
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
