using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SaveData{
    public SaveData(bool _sound, bool _backgroundsound, List<int> _stage1,List<int> _stage2,List<int> _stage3,List<int> _stage4,List<int> _stage5){
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


public static class SaveSystem{
    private static string SavePath => Application.persistentDataPath + "/saves/";

		public static void Save(SaveData saveData, string saveFileName)
		{
			if(!Directory.Exists(SavePath))
			{
				Directory.CreateDirectory(SavePath);
			}

			string saveJson = JsonUtility.ToJson(saveData);

			string saveFilePath = SavePath + saveFileName + ".json";
			File.WriteAllText(saveFilePath, saveJson);
			Debug.Log("Save Success: " + saveFilePath);
		}

		public static SaveData Load(string saveFileName)
		{
			string saveFilePath = SavePath + saveFileName + ".json";
			
            while(true){
            if(!File.Exists(saveFilePath))
			{   
                List<int> x = new List<int>();
                for(int i=0;i<25;i++){
                    x.Add(0);
                }
				Debug.LogError("No such saveFile exists");
                SaveData gamedata = new SaveData(true,false,x,x,x,x,x);
                SaveSystem.Save(gamedata, "user_data");
				continue;
			}

			string saveFile = File.ReadAllText(saveFilePath);
			SaveData saveData = JsonUtility.FromJson<SaveData>(saveFile);
            Debug.Log("load success");
			return saveData;
            }
			
		}

        
}


public class ingamescript : MonoBehaviour
{
public void loadgamedata(){
    SaveData loadData = SaveSystem.Load("user_data");
    UserDataManager UserDataManager = gameObject.AddComponent<UserDataManager>();
    UserDataManager.instance.sound = loadData.sound;
    UserDataManager.instance.backgroundsound = loadData.backgroundsound;

    for (int i = 0; i < loadData.Stage1.Count; i++) {
        UserDataManager.instance.Stage1.Add(loadData.Stage1[i]); }

    for (int i = 0; i < loadData.Stage2.Count; i++) {
        UserDataManager.instance.Stage2.Add(loadData.Stage2[i]); }

    for (int i = 0; i < loadData.Stage3.Count; i++) {
        UserDataManager.instance.Stage3.Add(loadData.Stage3[i]); }

    for (int i = 0; i < loadData.Stage4.Count; i++) {
        UserDataManager.instance.Stage4.Add(loadData.Stage4[i]); }

    for (int i = 0; i < loadData.Stage5.Count; i++) {
        UserDataManager.instance.Stage5.Add(loadData.Stage5[i]); }  
    
    DontDestroyOnLoad(UserDataManager);
}
   
}
