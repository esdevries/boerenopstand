using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerMove2 : MonoBehaviour
{

    public float speed = 9.0f;






    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (dialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;

        }
       


        // move
        var horizontal = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(horizontal, 0, 0) * (speed * Time.deltaTime));

        // flip
        Vector3 flip = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {

            flip.x = 2.4f;

        }


        if (Input.GetAxis("Horizontal") > 0)
        {

            flip.x = -2.4f;

        }

        transform.localScale = flip;




    }



}