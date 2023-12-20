using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{

    public GameObject resumeBtn;
    public GameObject pauseBtn;
    public GameObject leftBtn;
    public GameObject rightBtn;
    public GameObject thrustBtn;
    public GameObject homeBtn;
     public GameObject exitBtn;

    private void Start() {
        resumeBtn.SetActive(false);
        homeBtn.SetActive(false);
        exitBtn.SetActive(false);
    }

 
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseBtn.SetActive(false);
        leftBtn.SetActive(false);
        rightBtn.SetActive(false);
        thrustBtn.SetActive(false);
        resumeBtn.SetActive(true);
        homeBtn.SetActive(true);
        exitBtn.SetActive(true);
       
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; 
        pauseBtn.SetActive(true);
        leftBtn.SetActive(true);
        rightBtn.SetActive(true);
        thrustBtn.SetActive(true);
         resumeBtn.SetActive(false);
         homeBtn.SetActive(false);
         exitBtn.SetActive(false);
        
    }
    public void goHome(){
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Levelselector");
    }

    public void exitGame(){
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Home");
    }

    
}
