using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rel : MonoBehaviour
{
    private RectTransform rectTransform2;
    public bool goedr;

    private static rel instance;
    private void Awake()
    {



        rectTransform2 = GetComponent<RectTransform>();
        if (instance != null)
        {

            Debug.LogWarning("Found more than 1 dialogueM in scene");

        }

        instance = this;

    }

    public static rel GetInstance()
    {

        return instance;


    }



    void Start()
    {

    }


    void Update()
    {

        if (rectTransform2.anchoredPosition.x == 250 && rectTransform2.anchoredPosition.y == -450)
        {
            goedr = true;

        }
        else
        {
            goedr = false;

        }

    }
}
