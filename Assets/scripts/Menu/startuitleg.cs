using UnityEngine;
using UnityEngine.SceneManagement;

public class startuitleg : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("uitlegscene");
    }
}
