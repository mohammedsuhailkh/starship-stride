using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{

  
   public void caveLevel(){
    
    SceneManager.LoadScene("caveL1");
    Debug.Log("cave Level");
   }

    public void forestLevel(){

    SceneManager.LoadScene("forestL1");
   }

    public void mountainLevel(){

    SceneManager.LoadScene("mountainL1");
   }
}
