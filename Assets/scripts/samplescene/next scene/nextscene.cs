using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{

    void Update()
    {
        if (dialogueManager.GetInstance().dialogueHasPlayed)
        {

            SceneManager.LoadScene("scene 3");

        }
    }       






}
