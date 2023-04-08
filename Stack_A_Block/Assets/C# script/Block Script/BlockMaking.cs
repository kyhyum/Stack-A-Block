using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMaking : MonoBehaviour
{   
    public GameObject[] DropBlock; //떨어질 블록 리스트
    
    public void blockSpawn(int blocknum){
        if(DropBlock.Length == blocknum){

        }else{
            GameObject block = Instantiate(DropBlock[blocknum],transform.position,DropBlock[blocknum].transform.rotation);
        }
    }

    void Start()
    {

    }

    void Update()
    {   
        
    }
}
