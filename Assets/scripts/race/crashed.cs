using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crashed : MonoBehaviour
{
    public Animator transitionAnim2;
    public string sceneName2;


    void Update()
    {
       

        if (trekker.GetInstance2().hasCrashed)
        {
            // Debug.Log("oof");
            StartCoroutine(LoadScene());

        }


        IEnumerator LoadScene()
        {

            transitionAnim2.SetTrigger("boem");
            

            yield return new WaitForSeconds(3f);


          //  SceneManager.LoadScene(sceneName2);


        }

    }

}
