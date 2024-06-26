using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fade : MonoBehaviour
{

    public Animator transitionAnim2;
    public string sceneName2;


    // Start is called before the first frame update
    void Start()


    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trekker.GetInstance2().hasCrashed)
        {
            
            StartCoroutine(LoadScene());

        }


        IEnumerator LoadScene()
        {
            yield return new WaitForSeconds(3f);

            transitionAnim2.SetTrigger("end");


            yield return new WaitForSeconds(1.5f);


            SceneManager.LoadScene(sceneName2);


        }
    }
}
