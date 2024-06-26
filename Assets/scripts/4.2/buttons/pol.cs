using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pol : MonoBehaviour
{
    private RectTransform rectTransform2;
    public bool goedp;

    private static pol instance;
    private void Awake()
    {



        rectTransform2 = GetComponent<RectTransform>();
        if (instance != null)
        {

            Debug.LogWarning("Found more than 1 dialogueM in scene");

        }

        instance = this;

    }

    public static pol GetInstance()
    {

        return instance;


    }



    void Start()
    {

    }


    void Update()
    {

        if (rectTransform2.anchoredPosition.x == 250 && rectTransform2.anchoredPosition.y == 150)
        {
            goedp = true;
            
        }
        else
        {
            goedp = false;

        }

    }
}