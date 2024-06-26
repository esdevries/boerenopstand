using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 swit = transform.localScale;

        if (agent.GetInstance().coll && !dialogueManager.GetInstance().dialogueIsPlaying)
        {
            
            transform.Translate(new Vector3(-3*3, 0, 0) * Time.deltaTime);
            swit.x = 1.8f;
        }



        transform.localScale = swit;

    }
}
