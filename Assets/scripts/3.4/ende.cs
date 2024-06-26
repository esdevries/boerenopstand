using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class ende : MonoBehaviour
    {
        public Animator transitionAnim;
        public string sceneName;
        private bool cras = false;
         void Update()
        {


            if (cras == true)
            {

                StartCoroutine(LoadScene());
            }


            IEnumerator LoadScene()
            {

                transitionAnim.SetTrigger("end");
                yield return new WaitForSeconds(1.5f);

                SceneManager.LoadScene(sceneName);


            }

        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        cras = true;
    }

}


