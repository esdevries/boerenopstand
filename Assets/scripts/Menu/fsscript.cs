using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fsscript : MonoBehaviour
{
    public void Change()
    {
        Screen.fullScreen = !Screen.fullScreen;
        Debug.Log("scherm");
    }
}
