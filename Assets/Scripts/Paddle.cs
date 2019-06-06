using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool autoPlay = false;
    private ball Ball;

    void Start(){
        Ball = GameObject.FindObjectOfType<ball>();
        print(Ball);
    }
    // Update is called once per frame
    void Update(){
        if(!autoPlay){
        MoveWithMouse();
        }else{
            AutoPlay();
        }
    }
    void MoveWithMouse(){
        //a variable of vector3 type for paddle position as transform.position reuturn of type vector3
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f); //for keeping y position
        float mousePosInBlocks = Input.mousePosition.x/ Screen.width * 16; //Game space is 16 world units wide
        //print (mousePosInBlocks);
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
        this.transform.position = paddlePos; //this is not neccesary   
    }
    void AutoPlay(){
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f); //for keeping y position
        Vector3 ballPos = Ball.transform.position; //Game space is 16 world units wide
        //print (mousePosInBlocks);
        paddlePos.x = Mathf.Clamp(ballPos.x, 0.5f, 15.5f);
        this.transform.position = paddlePos; //this is not neccesary 
    }
}
