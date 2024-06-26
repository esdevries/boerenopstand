using UnityEngine;
using System.Collections;

public class geluidverdelen : MonoBehaviour
{

    private static geluidverdelen instance = null;
    public static geluidverdelen Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
