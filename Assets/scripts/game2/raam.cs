using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raam : MonoBehaviour
{
    private SpriteRenderer sprite;
    private static raam instance;

    private void Awake()
    {




        if (instance != null)
        {

            Debug.LogWarning("Found more than 1 dialogueM in scene");

        }

        instance = this;

    }

    public static raam GetInstance()
    {

        return instance;


    }

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sprite.sortingOrder = 10000;
        totaal.GetInstance().total += 1;
    }


}
