using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diatrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    int i = 0;

    private void Update()
    {


        if (!dialogueManager.GetInstance().dialogueIsPlaying && agent.GetInstance().coll)
        {


            if (i < 1)
            {

                dialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                i += 1;

            }


        }



    }
}
