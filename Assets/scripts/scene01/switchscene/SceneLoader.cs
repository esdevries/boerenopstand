using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    void Update()
    {
        if (dialogueManager.GetInstance().dialogueHasPlayed)
        {

            SceneManager.LoadScene("scene 2");

        }
    }






}
    
