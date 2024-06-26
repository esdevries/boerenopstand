using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialoguet3 : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    int i = 0;

    private void Update()
    {


        if (!dialogueManager.GetInstance().dialogueIsPlaying)
        {

           
            if (i<1)
            {

                dialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                i += 1;

            }


        }



    }




}
