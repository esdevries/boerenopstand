using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okfwkfas : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    int i = 0;
    private static okfwkfas instance;
    
    public bool nein = false;

    private void Awake()
    {




        if (instance != null)
        {

            Debug.LogWarning("Found more than 1 dialogueM in scene");

        }

        instance = this;

    }


    private void Update()
    {


        if (!dialogueManager.GetInstance().dialogueIsPlaying)
        {
            

            if (i < 1)
            {

                dialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                i += 1;

            }


        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            nein = true;
        }


    }


    public static okfwkfas GetInstance()
    {

        return instance;


    }

}
