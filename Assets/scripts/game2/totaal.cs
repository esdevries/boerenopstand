using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totaal : MonoBehaviour
{
    private static totaal instance;
    public int total = 0;
    public Text ram;
    
    

    private void Awake()
    {




        if (instance != null)
        {

            Debug.LogWarning("Found more than 1 dialogueM in scene");

        }

        instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        ram = GetComponent<Text>();
        
       
    }

    // Update is called once per frame
    void Update()
    {
        ram.text = "Aantal ramen: " + total + "\nAantal Bakstenen: " + player22.GetInstance().aantal;
        
    }


    public static totaal GetInstance()
    {

        return instance;


    }
}
