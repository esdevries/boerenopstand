using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;

public class dialogueManager : MonoBehaviour
{


    [Header("Params")]
    [SerializeField] private float typingSpeed = 0.04f;

    private static dialogueManager instance;
    private Coroutine displayLineCoroutine;  

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI displayNameText;
    [SerializeField] private Animator portraitAnimator;
    private bool canContinueToNextLine = false;

    private Story currentStory;
    public bool dialogueIsPlaying { get; private set; }
    public bool dialogueHasPlayed { get; private set; }

    private const string SPEAKER_TAG = "speaker";
    private const string PORTRAIT_TAG = "portrait";
    private const string LAYOUT_TAG = "layout";

    private void Awake() {

        


        if (instance != null) {

            Debug.LogWarning("Found more than 1 dialogueM in scene");
        
        }

        instance = this;

    }

    public static dialogueManager GetInstance() {

        return instance;
    
    
    }

    private void Start()
    {

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);


    }


    private void Update()
    {

        if (!dialogueIsPlaying)
        {

            return;

        }

        if (Input.GetKeyDown(KeyCode.Space) && canContinueToNextLine)
        {

            ContinueStory();


        }


    }


    public void EnterDialogueMode(TextAsset inkJSON) {


        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        ContinueStory();


    }


    private IEnumerator ExitDialogueMode()
    {
        yield return new WaitForSeconds(0.00000000000002f);

        dialogueHasPlayed = true;
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";

        
    }


    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {

            if (displayLineCoroutine != null)
            {

                StopCoroutine(displayLineCoroutine);

            }
            displayLineCoroutine = StartCoroutine(DisplayLine(currentStory.Continue())); 

            HandleTags(currentStory.currentTags);

        }
        else
        {

            StartCoroutine(ExitDialogueMode());

        }



    }


    private IEnumerator DisplayLine(string line)
    {

        dialogueText.text = "";

        canContinueToNextLine = false;


        foreach (char letter in line.ToCharArray())
        {
            if (Input.GetKey(KeyCode.E))
            {

                dialogueText.text = line;
                break;

            }

            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);




        }



        canContinueToNextLine = true;

    }




    private void HandleTags(List<string> currentTags)
    {

        foreach (string tag in currentTags)
        {

            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {

                Debug.LogError("Tag could not be parsed: " + tag);

            }

            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();


            switch (tagKey)
            {

                case SPEAKER_TAG:
                    displayNameText.text = tagValue;
                    break;
                case PORTRAIT_TAG:
                    portraitAnimator.Play(tagValue);
                    break;
                case LAYOUT_TAG:
                    Debug.Log("layout= " + tagValue);
                    break;
                default:
                    Debug.LogWarning("Tag came in but is not handled: " + tag);
                    break;





            }




        }


    }



}
