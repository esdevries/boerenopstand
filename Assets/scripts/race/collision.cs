using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public float speed = 9.0f;


    void Update()
    {

        if (dialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;

        }

        if(hek.GetInstance().hasFinished)
        {

            

            transform.Translate(new Vector3(0.5f, 0, 0) * (speed * Time.deltaTime));


        }

        if (dialogueManager.GetInstance().dialogueHasPlayed && !trekker.GetInstance2().hasCrashed && !hek.GetInstance().hasFinished)
        {

            var horizontal = 1.5f;

            transform.Translate(new Vector3(horizontal, 0, 0) * (speed * Time.deltaTime));





        }
    }
}

