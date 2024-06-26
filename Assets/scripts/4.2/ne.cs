using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ne : MonoBehaviour
{
    
    public string sceneName;
    
    void Update()
    {


        if (ruil.GetInstance().goedru && burge.GetInstance().goedb && pol.GetInstance().goedp && rel.GetInstance().goedr && boer.GetInstance().goedbo)
        {

            StartCoroutine(LoadScene());
        }


        IEnumerator LoadScene()
        {

            
            yield return new WaitForSeconds(1f);

            SceneManager.LoadScene(sceneName);


        }

    }
}
