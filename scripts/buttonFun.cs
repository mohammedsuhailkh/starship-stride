using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFun : MonoBehaviour
{
    

   

    
    // Start is called before the first frame update
  
    public void startLevel(){
       
        SceneManager.LoadScene("LevelSelector");
    }

     public void home(){
        SceneManager.LoadScene("Home");
    }

     public void info(){
        SceneManager.LoadScene("Info");
    }
}
