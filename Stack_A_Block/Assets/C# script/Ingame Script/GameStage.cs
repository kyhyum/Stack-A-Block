using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStage : MonoBehaviour
{
    public UserDataManager userdatamanager;
    public BlockMaking blockmaking;
    public GameClearpopupset gameclearpopupset;
    public Timer timer;
    public int Stagenum;
    public int blocknum;
    public int num;

    private SpriteRenderer[] blocklistrenderer = new SpriteRenderer[8];
    public GameObject[] BlockList; //상단에 뜨는 블록 리스트
    public Sprite[] BlockimgList; // 상단에 뜨는 블록 이미지 리스트

    public void blocknumplus(){
        ++blocknum;
        nextBlockView(blocknum);
        blockmaking.blockSpawn(blocknum);
    }



    public void nextBlockView(int blocknum){
        if(blocknum == 1){
            Debug.Log(blocknum);
            timer.timerstart();
        }
        if(BlockimgList[blocknum] == null){
            TimerToastmanager.Instrance.showMessage("5",1f);
            Invoke("four_second",1f);
            Invoke("three_second",2f);
            Invoke("two_second",3f);
            Invoke("one_second",4f);
            Invoke("zero_second",5f);
        }else{
            for(int i = 0 ; i<8 ; i++){
            if(BlockimgList[i+blocknum] == null){
                for(int k =0; k < blocknum ; k++){
                    if(i+k == 8){
                        break;
                    }else{
                        blocklistrenderer[i+k].sprite = null;
                    }
                }
                break;
            }else{
                blocklistrenderer[i].sprite = BlockimgList[i+blocknum+1];
            }
        }
        }
    }
    void zero_second(){
        Time.timeScale = 0;
        if(num == 1){
            if(userdatamanager.Stage1[Stagenum] > timer.timerstop()){
                userdatamanager.Stage1[Stagenum] = timer.timerstop();
                userdatamanager.OverwriteData();
            }else if(userdatamanager.Stage1[Stagenum] == 0){
                userdatamanager.Stage1[Stagenum] = timer.timerstop();
                userdatamanager.OverwriteData();
            }
            gameclearpopupset.setstar();
            gameclearpopupset.gameclearpopup_active();
        }else if(num == 2){
            if(userdatamanager.Stage2[Stagenum] > timer.timerstop()){
                userdatamanager.Stage2[Stagenum] = timer.timerstop();
                userdatamanager.OverwriteData();
            }else if(userdatamanager.Stage2[Stagenum] == 0){
                userdatamanager.Stage2[Stagenum] = timer.timerstop();
                userdatamanager.OverwriteData();
            }
            gameclearpopupset.setstar();
            gameclearpopupset.gameclearpopup_active();
        }else{
            if(userdatamanager.Stage3[Stagenum] > timer.timerstop()){
                userdatamanager.Stage3[Stagenum] = timer.timerstop();
                userdatamanager.OverwriteData();
            }else if(userdatamanager.Stage3[Stagenum] == 0){
                userdatamanager.Stage3[Stagenum] = timer.timerstop();
                userdatamanager.OverwriteData();
            }
            gameclearpopupset.setstar();
            gameclearpopupset.gameclearpopup_active();
        }
        
            
    }
    void one_second(){
        TimerToastmanager.Instrance.showMessage("1",1f);
    }
    void two_second(){
        TimerToastmanager.Instrance.showMessage("2",1f);
    }
    void three_second(){
        TimerToastmanager.Instrance.showMessage("3",1f);
    }
    void four_second(){
        TimerToastmanager.Instrance.showMessage("4",1f);
    }

    // Start is called before the first frame update
    void Start()
    {
        blocknum = 0;
        gameclearpopupset = GameObject.Find("nextstage").GetComponent<GameClearpopupset>();
        gameclearpopupset.gameclearpopup_unactive();
        userdatamanager =GameObject.Find("ingamescript").GetComponent<UserDataManager>();
        timer = GameObject.Find("timer").GetComponent<Timer>();
        blockmaking = GameObject.Find("BlockSlot").GetComponent<BlockMaking>();
        for(int i = 0 ; i < 8 ; i++){
            blocklistrenderer[i] = BlockList[i].GetComponent<SpriteRenderer>();
        }
        nextBlockView(blocknum);
        blockmaking.blockSpawn(blocknum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
