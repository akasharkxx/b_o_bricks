using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //a variable of vector3 type for paddle position as transform.position reuturn of type vector3
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f); //for keeping y position

        float mousePosInBlocks = Input.mousePosition.x/ Screen.width * 16; //Game space is 16 world units wide
        //print (mousePosInBlocks);

        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
        this.transform.position = paddlePos; //this is not neccesary   
    }
}
