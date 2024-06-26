using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger2 : MonoBehaviour
{


    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;




    private bool playerInRange;



    private void Awake()
    {


        playerInRange = false;
        visualCue.SetActive(false);



    }


    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "Player")
        {

            playerInRange = true;

        }


    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {

            playerInRange = false;
        }

    }


    private void Update()
    {


        if (playerInRange && !dialogueManager2.GetInstance().dialogueIsPlaying)
        {

            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {

                dialogueManager2.GetInstance().EnterDialogueMode(inkJSON);

            }


        }

        else
        {

            visualCue.SetActive(false);


        }



    }



}