using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscene2 : MonoBehaviour
{
    void Update()
    {
        if (dialogueManager.GetInstance().dialogueHasPlayed)
        {

            SceneManager.LoadScene("SampleScene");

        }
    }



}
