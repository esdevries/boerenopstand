using UnityEngine;
using UnityEngine.SceneManagement;

 class LeaveGame : MonoBehaviour
{
    public void doExitGame()
    {
        Application.Quit();
        Debug.Log("spelletje legt het loodje");
    }
}
