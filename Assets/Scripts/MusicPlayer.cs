using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer instance = null;
    void Start(){
        if(instance != null){
            Destroy(gameObject);
            Debug.Log("Duplicate Destroyed");
        }else{
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
           
    }
}
