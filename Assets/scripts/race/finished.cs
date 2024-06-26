using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finished : MonoBehaviour
{
    public Animator transitionAnim;
    
    

    void Update()
    {


        if (hek.GetInstance().hasFinished)
        {

            StartCoroutine(LoadScene());
           
        }


        IEnumerator LoadScene()
        {

            transitionAnim.SetTrigger("hek");

            yield return new WaitForSeconds(3f);

            


        }

    }

}
