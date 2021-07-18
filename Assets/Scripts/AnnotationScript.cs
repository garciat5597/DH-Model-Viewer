using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnnotationScript : MonoBehaviour
{
    [SerializeField]
    string annotationTitle = "This is a title";
    [SerializeField]
    string annotationText = "This is an annotation";
    public Text textBox;
    public Text titleBox;
    // Start is called before the first frame update
    void Start()
    {
        if (!textBox)
        {
            textBox = GameObject.Find("AnnotationTextbox").GetComponent<Text>();
        }
        if (!titleBox)
        {
            titleBox = GameObject.Find("AnnotationTitlebox").GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Find new textbox if the variable is ever invalid, after changing scenes etc
        if (!textBox)
        {
            textBox = GameObject.Find("AnnotationTextbox").GetComponent<Text>();
        }
        if (!titleBox)
        {
            titleBox = GameObject.Find("AnnotationTitlebox").GetComponent<Text>();
        }
    }

    private void OnMouseDown()
    {
        // Reset text if already active
        if(titleBox.text == annotationTitle)
        {
            titleBox.text = "";
            textBox.text = "";
        }
        else
        {
            titleBox.text = annotationTitle;
            textBox.text = annotationText;
        }
    }


    private void OnMouseExit()
    {
       // textBox.text = "";
    }
}
