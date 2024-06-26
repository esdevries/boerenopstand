using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player22 : MonoBehaviour
{
    public int aantal = 150;
    public float speed = 9.0f;
    public projectile ProjectilePrefab;
    public Transform LaunchOffset;
    public bool ended = false;
    private static player22 instance;
    
    void Start()
    {

    }
    private void Awake()
    {




        if (instance != null)
        {

            Debug.LogWarning("Found more than 1 dialogueM in scene");

        }

        instance = this;

    }

    void Update()
    {

        if (dialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;

        }

        if(ended == false)
        {
            var horizontal = 1.5f;
            transform.Translate(new Vector3(-horizontal, 0, 0) * (speed * Time.deltaTime));

           // if (Input.GetKey(KeyCode.A))
          //  {

            //  transform.Translate(new Vector3(-horizontal-1, 0, 0) * (speed * Time.deltaTime));

          //  }

          //  if (Input.GetKey(KeyCode.D))
          //  {

           //     transform.Translate(new Vector3(3*horizontal - 1, 0, 0) * (speed * Time.deltaTime));

         //   }


        }
        

        


        if (Input.GetKeyDown("space") && aantal > 0)
        {

            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
            aantal -= 1;
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "eind")
        {
            ended = true;
        }
    }

    public static player22 GetInstance()
    {

        return instance;


    }
}
