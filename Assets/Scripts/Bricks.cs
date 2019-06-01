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
    }

    // Update is called once per frame
    void Update(){
        
    }
    void OnCollisionEnter2D (Collision2D collision){
        timesHit++;
        SimulateWin();
    }// TODO remove this function once we can win!!!
    void SimulateWin() {
        levelmanager.LoadNextLevel();
    }
}
