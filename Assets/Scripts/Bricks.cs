using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public int maxHits;
    private LevelManager levelmanager;
    private int timesHit;
    // Start is called before the first frame update
    void Start(){
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
        timesHit = 0;
    }//end of Start

    // Update is called once per frame
    void Update(){
        
    }//end of Update
    void OnCollisionEnter2D (Collision2D collision){        
        //increment timesHit if ball hits the bricks    
        timesHit++;
        //Setting conditions for different blocks to be destroyed after certain hits
        if(timesHit >= maxHits){
            Destroy(gameObject);
        }//end of if statements
          
    }//End of OnCollisionEnter2D
    void SimulateWin() {
        levelmanager.LoadNextLevel();
    }//End of SimulateWin
}
