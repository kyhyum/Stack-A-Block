using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    public GameStage stage;

    [SerializeField]
    private Rigidbody2D Rigid;
    private Collider2D coll;
    private Vector3 _dragOffset;
    private Camera _cam;
    private Vector3 vector3 = new Vector3(0.6f,0.6f,0);
    private Vector3 initposition;
    private Vector3 diff;
    public bool clickactive = true;
    void Start(){
        stage = GameObject.Find("Stage").GetComponent<GameStage>();
        initposition = transform.position;
        Rigid = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }
    void Awake(){
        _cam = Camera.main;
    }

    void OnMouseDown(){
        if(clickactive == true){
            _dragOffset = transform.position - GetMousePos();
        }
    }

    void OnMouseDrag(){
        if(clickactive == true){
            transform.position = GetMousePos() + _dragOffset;
        }
    }

    void OnMouseUp(){
        if(clickactive == true){
            if(transform.position.x > (initposition - vector3).x && transform.position.x < (initposition + vector3).x && transform.position.y > (initposition - vector3).y && transform.position.y < (initposition + vector3).y){
            //그림자에 놨을 때
            diff = initposition - transform.position;
            transform.position += diff;
        }else{
            //그림자 밖에 놨을 때
            clickactive = false;
            stage.blocknumplus();
            alterdynamic();
            coll.isTrigger = false;
        }
        }
        
    }

    void alterdynamic(){
        Rigid.bodyType = RigidbodyType2D.Dynamic;
    }


    Vector3 GetMousePos(){
        var mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
