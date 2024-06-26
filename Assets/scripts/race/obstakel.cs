using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstakel : MonoBehaviour
{
    private static obstakel instance2;
   
    public bool hasCrashed { get; private set; }


    private void Awake()
    {




        if (instance2 != null)
        {

            Debug.LogWarning("helaas");

        }

        instance2 = this;

    }

    private void Start()
    {

        hasCrashed = false;


    }
    

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "racer")
        {

            hasCrashed = true;
            Debug.Log(hasCrashed);
            
            

          


        }
    }

    public static obstakel GetInstance2()
    {

        return instance2;


    }

}
