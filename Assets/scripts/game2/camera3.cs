using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera3 : MonoBehaviour
{

    public bool running = true;
    public float speed = 9.0f;



    void Update()
    {

        if (dialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;

        }

        if (running && !player22.GetInstance().ended)
        {

            var horizontal = 1.5f;

            transform.Translate(new Vector3(-horizontal, 0, 0) * (speed * Time.deltaTime));

        }





    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "eind")
        {
            running = false;
        }
    }




}
