using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agent : MonoBehaviour
{
    
    private static agent instance;
    public bool coll = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {




        if (instance != null)
        {

            Debug.LogWarning("Found more than 1 dialogueM in scene");

        }

        instance = this;

    }
    // Update is called once per frame
    void Update()
    {

        if (coll == false)
        {

            transform.Translate(new Vector3(-3, 0, 0) * Time.deltaTime);


        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "coll")
        {

            coll = true;
            Debug.Log("trie");

        }
    }

    public static agent GetInstance()
    {

        return instance;


    }
}
