using TMPro;
using UnityEngine;

public class TextBox : MonoBehaviour
{
    //reference to the textbox canvas
    public GameObject textBoxCanvas;

    //reference to the Text object in the canvas
    public TMP_Text textBoxContents;

    //text that we want to display. you will set it in the inspector
    public string[] theText;

    private int currentSentence = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //make sure the TextBox is not
        //active and visible when the scene starts
        textBoxCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentSentence++;
            if (currentSentence >= theText.Length)
            {
                hideTextBox();
            }
            else
            {
                textBoxContents.text = theText[currentSentence];
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //reset the currentSentence
            currentSentence = 0;

            //show the textbox
            textBoxCanvas.SetActive(true);

            //set the text
            textBoxContents.text = theText[0];
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //call the function to hide the textbox
            hideTextBox();
        }
    }

    private void hideTextBox()
    {
        //hide the textbox
        textBoxCanvas.SetActive(false);

        //reset the currentSentence
        currentSentence = 0;
    }



}

