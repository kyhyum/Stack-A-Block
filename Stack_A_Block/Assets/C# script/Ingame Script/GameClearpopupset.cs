using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearpopupset : MonoBehaviour
{
    public UserDataManager userdatamanager;
    public Stagenum getstagenum;
    public GameObject GameClearpopup;
    public GameObject GameClearpopup_star;
    public Sprite[] starlists;
    public int num;

    public void Stagenumplus(){
        if(num == 1 && getstagenum.stagenum == 24){
             SceneManager.LoadScene("stage2");
        }else if(num == 2 && getstagenum.stagenum == 24){
            SceneManager.LoadScene("stage3");
        }else if(num == 3 && getstagenum.stagenum == 24){
            SceneManager.LoadScene("stage3");
            TimerToastmanager.Instrance.showMessage("All Stage Clear!!!",1f);
        }else{
            getstagenum.stagenum++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameclearpopup_unactive();
        }
    }

    public void gameclearpopup_active(){
        GameClearpopup.SetActive(true);
    }
    
    public void gameclearpopup_unactive(){
        GameClearpopup.SetActive(false);
    }

    public void setstar(){
        if(num == 0){
            if(userdatamanager.Stage1[getstagenum.stagenum] <= 30){
                GameClearpopup_star.GetComponent<SpriteRenderer>().sprite = starlists[0];
            }else if(userdatamanager.Stage1[getstagenum.stagenum] <= 60 && userdatamanager.Stage1[getstagenum.stagenum] > 30){
                GameClearpopup_star.GetComponent<SpriteRenderer>().sprite = starlists[1]; 
            }
        }else if(num == 1){
            if(userdatamanager.Stage2[getstagenum.stagenum] <= 30){
                GameClearpopup_star.GetComponent<SpriteRenderer>().sprite = starlists[0];
            }else if(userdatamanager.Stage2[getstagenum.stagenum] <= 60 && userdatamanager.Stage2[getstagenum.stagenum] > 30){
                GameClearpopup_star.GetComponent<SpriteRenderer>().sprite = starlists[1]; 
            }
        }else{
            if(userdatamanager.Stage3[getstagenum.stagenum] <= 30){
                GameClearpopup_star.GetComponent<SpriteRenderer>().sprite = starlists[0];
            }else if(userdatamanager.Stage3[getstagenum.stagenum] <= 60 && userdatamanager.Stage3[getstagenum.stagenum] > 30){
                GameClearpopup_star.GetComponent<SpriteRenderer>().sprite = starlists[1]; 
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        GameClearpopup_star = GameObject.Find("gameclearStar");
        userdatamanager =GameObject.Find("ingamescript").GetComponent<UserDataManager>();
        GameClearpopup = GameObject.Find("popupGameClearCanvas");
        getstagenum = GameObject.Find("Stagenum").GetComponent<Stagenum>();
        GameClearpopup_star = GameObject.Find("gameclearStar");
        gameclearpopup_unactive();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
