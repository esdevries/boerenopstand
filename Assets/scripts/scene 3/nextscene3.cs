using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene3 : MonoBehaviour
{
    void Update()
    {
        if (dialogueManager.GetInstance().dialogueHasPlayed)
        {

            SceneManager.LoadScene("scene 4");

        }
    }

}
