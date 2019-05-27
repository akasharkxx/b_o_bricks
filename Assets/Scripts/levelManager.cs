using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    public void LoadLevel(string name){
        Debug.Log("Level load requested for: " + name);
        Application.LoadLevel(name);
    }
    public void QuitRequest(){
        Debug.Log("Quit");
        Application.Quit();
    }
}
