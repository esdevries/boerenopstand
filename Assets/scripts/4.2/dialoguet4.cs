using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialoguet4 : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    int i = 0;

    private void Update()
    {


        if (!daloguem4.GetInstance().dialogueIsPlaying)
        {


            if (i < 1)
            {

                daloguem4.GetInstance().EnterDialogueMode(inkJSON);
                i += 1;

            }


        }



    }
}
