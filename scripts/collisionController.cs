using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionController : MonoBehaviour
{

    [SerializeField] float delay = 1f;
    [SerializeField] AudioClip crash;
    [SerializeField] AudioClip finish;
    [SerializeField] ParticleSystem crashParticles;
    private bool isTransitioning = false;



    // Start is called before the first frame update
    private void Start() {
        
    }
   private void OnCollisionEnter(Collision other) {

    if(isTransitioning){ return ;}
        switch (other.gameObject.tag)
        {
            case "startPad":
            break;

            case "finish":
            completedSeq();
            break;

            
            default:
            crashSeq();
            break;
        }
   }

   void crashSeq(){
    
    isTransitioning = true;
    crashParticles.Play();
    GetComponent<movement>().sound.PlayOneShot(crash);
    GetComponent<movement>().enabled = false;
    Invoke("reloadLevel", delay);

   
   }

   void completedSeq(){
    isTransitioning = true;
    
    GetComponent<movement>().sound.PlayOneShot(finish);
    GetComponent<movement>().enabled = false;
    Invoke("LoadNextScene", delay);

   }

   void reloadLevel(){
    int currentScene = SceneManager.GetActiveScene().buildIndex;
   
    SceneManager.LoadScene(currentScene);
   }

    // void LoadNextScene()
    // {
    //     int currentScene = SceneManager.GetActiveScene().buildIndex;
    //      int nextScene = currentScene + 1;
    // if(nextScene == SceneManager.sceneCountInBuildSettings){
    //     nextScene = 1;
    // }
    //     SceneManager.LoadScene(nextScene);
    // }

    void LoadNextScene()
{
    int currentScene = SceneManager.GetActiveScene().buildIndex;
    int nextScene = currentScene + 1;

    // Check if the next scene is "forestL1" or "mountainL1"
    if (IsSpecialScene(nextScene))
    {
        SceneManager.LoadScene(1); // Load scene 1
    }
    else
    {
        // Load the next scene within the current stage
        if (nextScene == SceneManager.sceneCountInBuildSettings)
        {
            // Wrap around to the first level of the current stage
            nextScene = currentScene - (currentScene % 10) + 1;
        }

        SceneManager.LoadScene(nextScene);
    }
}

bool IsSpecialScene(int sceneIndex)
{
    // Define the special scenes here
    string[] specialScenes = { "forestL1", "mountainL1" };

    // Check if the scene at the given index is a special scene
    string sceneName = SceneUtility.GetScenePathByBuildIndex(sceneIndex);
    foreach (var specialScene in specialScenes)
    {
        if (sceneName.Contains(specialScene))
        {
            return true;
        }
    }

    return false;
}





}




