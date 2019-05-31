using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public int maxHits;
    private int timesHit;
    // Start is called before the first frame update
    void Start()
    {
        timesHit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D (Collision2D collision){
        timesHit++;
    }
}
