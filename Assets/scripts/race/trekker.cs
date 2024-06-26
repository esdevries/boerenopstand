using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trekker : MonoBehaviour
{

    public float speed = 9.0f;
    public bool hasCrashed;
    private static trekker instance2;

    private void Awake()
    {




        if (instance2 != null)
        {

            Debug.LogWarning("helaas");

        }

        instance2 = this;

    }
    public static trekker GetInstance2()
    {

        return instance2;


    }

    private void Start()
    {
        hasCrashed = false;
    }

    void Update()
    {

        if (dialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;

        }

        if (hek.GetInstance().hasFinished)
        {


            transform.Translate(new Vector3(0, 0.5f, 0) * (speed * Time.deltaTime));

        }


            
        if (dialogueManager.GetInstance().dialogueHasPlayed && !hek.GetInstance().hasFinished)
        {

            if (hasCrashed == false)
            {

                var horizontal = 1.5f + Input.GetAxis("Horizontal");

                transform.Translate(new Vector3(0, horizontal, 0) * (speed * Time.deltaTime));

                var vertical = Input.GetAxis("Vertical");

                transform.Translate(new Vector3(-vertical, 0, 0) * (1.2f * speed * Time.deltaTime));


            }
            

        }
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "muntje")
        {

            Destroy(col.gameObject);
        }

        if (col.tag == "obstakel")
        {
          
            hasCrashed = true;
        }

    }
    
}
