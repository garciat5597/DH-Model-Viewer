using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    public GameObject allObjects;
    public GameObject[] objects;
    public Text textBox;
    public Text titleBox;
    GameObject currentObject;

    private void Start()
    {
        currentObject = Instantiate(objects[0], objects[0].transform.position, objects[0].transform.rotation);
        DontDestroyOnLoad(currentObject);
        if (!textBox)
        {
            textBox = GameObject.Find("AnnotationTextbox").GetComponent<Text>();
        }
        if (!titleBox)
        {
            titleBox = GameObject.Find("AnnotationTitlebox").GetComponent<Text>();
        }
    }

    public void HandleInputData(int val)
    {
        // Clear the annotation box when changing objects
        if (!textBox)
        {
            textBox = GameObject.Find("AnnotationTextbox").GetComponent<Text>();
        }
        if (!titleBox)
        {
            titleBox = GameObject.Find("AnnotationTitlebox").GetComponent<Text>();
        }
        textBox.text = "";
        titleBox.text = "";

        Destroy(currentObject);
        currentObject = Instantiate(objects[val], objects[val].transform.position, objects[val].transform.rotation);
        DontDestroyOnLoad(currentObject);
    }
}
