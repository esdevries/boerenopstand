using UnityEngine;
using UnityEngine.SceneManagement;

public class Terugnaarmenu : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("mainmenu2");
    }
}
