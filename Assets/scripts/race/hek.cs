using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hek : MonoBehaviour
{
    private static hek instance;
    public bool hasFinished { get; private set; }


    private void Awake()
    {




        if (instance != null)
        {

            Debug.LogWarning("helaas");

        }

        instance = this;

    }

    private void Start()
    {

        hasFinished = false;


    }
    // Update is called once per frame
    void Update()
    {




    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "racer")
        {

            hasFinished = true;
            



        }
    }

    public static hek GetInstance()
    {

        return instance;


    }

}
