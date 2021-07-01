using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnnotationScript : MonoBehaviour
{
    [SerializeField]
    string annotationText = "This is an annotation";
    public Text textBox;
    // Start is called before the first frame update
    void Start()
    {
        if (!textBox)
        {
            textBox = GameObject.Find("AnnotationTextbox").GetComponent<Text>();
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
    }

    private void OnMouseEnter()
    {
        Debug.LogWarning("Annotation entered");
        textBox.text = annotationText;
    }

    private void OnMouseExit()
    {
        textBox.text = "";
    }
}
