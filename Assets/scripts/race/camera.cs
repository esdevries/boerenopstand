using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float speed = 9.0f;
    private static camera instance;
    

    void Update()
    {

        if (dialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;

        }



        if (dialogueManager.GetInstance().dialogueHasPlayed && !hek.GetInstance().hasFinished)
        {

            if (!trekker.GetInstance2().hasCrashed)
            {
                var horizontal = 1.5f;

                transform.Translate(new Vector3(horizontal, 0, 0) * (speed * Time.deltaTime));


            }

           
        }
    }

    public static camera GetInstance()
    {

        return instance;


    }

}
