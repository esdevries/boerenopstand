using UnityEngine;

public class Fullscreen : MonoBehaviour
{
    void Start()
    {
        
        Screen.fullScreen = !Screen.fullScreen;
    }
}