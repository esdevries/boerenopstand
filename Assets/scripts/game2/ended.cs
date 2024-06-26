using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ended : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;

  
    public string sceneName2;

    void Update()
    {


        if (player22.GetInstance().ended && totaal.GetInstance().total >= 75)
        {

            StartCoroutine(LoadScene());
        }


        IEnumerator LoadScene()
        {

            transitionAnim.SetTrigger("end");
            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene(sceneName);


        }

        if (player22.GetInstance().ended && totaal.GetInstance().total < 75)
        {

            StartCoroutine(LoadScene2());
        }


        IEnumerator LoadScene2()
        {

            transitionAnim.SetTrigger("end");
            yield return new WaitForSeconds(1.5f);

            SceneManager.LoadScene(sceneName2);


        }

    }
}
