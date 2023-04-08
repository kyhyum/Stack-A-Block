using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[System.Serializable]
public class OverwriteSaveData{
    public OverwriteSaveData(bool _sound, bool _backgroundsound, List<int> _stage1,List<int> _stage2,List<int> _stage3,List<int> _stage4,List<int> _stage5){
        sound = _sound;
        backgroundsound = _backgroundsound;
        Stage1 = _stage1;
        Stage2 = _stage2;
        Stage3 = _stage3;
        Stage4 = _stage4;
        Stage5 = _stage5;
    }

    public bool sound;
    public bool backgroundsound;
    public List<int> Stage1;
    public List<int> Stage2;
    public List<int> Stage3;
    public List<int> Stage4;
    public List<int> Stage5;
}

public class UserDataManager : MonoBehaviour
{
    private static string SavePath => Application.persistentDataPath + "/saves/";
    public ingamescript ingamescript;
    public static UserDataManager instance;

    public bool sound;
    public bool backgroundsound;
    public List<int> Stage1 = new List<int>();
    public List<int> Stage2 = new List<int>();
    public List<int> Stage3 = new List<int>();
    public List<int> Stage4 = new List<int>();
    public List<int> Stage5 = new List<int>();

    void Awake() {
        instance = this;    
    }

    public void OverwriteData(){
        OverwriteSaveData saveData = new OverwriteSaveData(sound,backgroundsound,Stage1,Stage2,Stage3,Stage4,Stage5);
        string saveJson = JsonUtility.ToJson(saveData);
        string saveFilePath = SavePath + "user_data" + ".json";
        File.WriteAllText(saveFilePath, saveJson);
    }
    
 
}
