using UnityEngine;
using UnityEngine.SceneManagement;

public class startsp : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("scene01");
    }
}
