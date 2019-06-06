using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Paddle paddle;
    private bool hasStarted = false;
    private Vector3 paddleToBallVector;
    // Start is called before the first frame update
    void Start() {
        paddle = GameObject.FindObjectOfType<Paddle>();
        //getting the current tranforms of both ball and paddle
        paddleToBallVector = this.transform.position - paddle.transform.position;
    }//end of method start
    
    // Update is called once per frame
    void Update()
    {
        if(!hasStarted){
            //to make ball stick to the paddle at the start of game
            this.transform.position = paddle.transform.position + paddleToBallVector;
            
            //to get mouse input and launch ball
            if(Input.GetMouseButtonDown (0)){
                print ("mouse clicked, launching ball");
                //make hasStarted true as this should not run after launching the ball
                hasStarted = true;
                //we need to give the ball some velocity
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }//end of if
        }//end of if
    }//end of update method
    void OnCollisionEnter2D (Collision2D collision){
        //for changing the velocity of the ball
        Vector2 tweak = new Vector2 (Random.Range(0f,0.2f),Random.Range(0f,0.2f));

        //for playing boing sound
        if(hasStarted){
            GetComponent<AudioSource>().Play();
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }
}
