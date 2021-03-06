﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public AudioClip crack;
    public static int breakableCount = 0;
    public Sprite[] hitSprites;
    private LevelManager levelmanager;
    private int timesHit;
    private bool isBreakable;
    // Start is called before the first frame update
    void Start(){
        isBreakable = (this.tag == "Breakable");

        //Keeping tracks of breakable bricks
        if(isBreakable){
            breakableCount++;
        }
        levelmanager = GameObject.FindObjectOfType<LevelManager>();
        timesHit = 0;
    }//end of Start

    // Update is called once per frame
    void Update(){
        
    }//end of Update
    void OnCollisionEnter2D (Collision2D collision){
        AudioSource.PlayClipAtPoint (crack, transform.position, 0.8f);        
        if(isBreakable){
        HandleHits();
        }
    }//End of OnCollisionEnter2D

    void HandleHits(){
        //increment timesHit if ball hits the bricks    
        timesHit++;
        int maxHits = hitSprites.Length + 1;
        //Setting conditions for different blocks to be destroyed after certain hits
        if(timesHit >= maxHits){
            breakableCount--;
            levelmanager.BrickDestroyed();
            Destroy(gameObject);
        }else{
            LoadSprites();
        }//end of if statements
    }
    void LoadSprites(){
         int spriteindex = timesHit - 1;
         //the following line changes sprites from sprite renderer
         if(hitSprites[spriteindex]){
         this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteindex];
         }
    }
    void SimulateWin() {
        levelmanager.LoadNextLevel();
    }//End of SimulateWin
}
