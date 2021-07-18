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
    GameObject Vase;
    GameObject Polyxena;
    GameObject KuanYu;
    GameObject Ding;
    GameObject Altarpiece;

    private void Start()
    {
        KuanYu = Instantiate(objects[2], objects[2].transform.position, objects[2].transform.rotation);
        DontDestroyOnLoad(KuanYu);
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

        if (val == 0)
        {
            Destroy(Polyxena);
            Destroy(KuanYu);
            Destroy(Ding);
            Destroy(Altarpiece);
            Vase = Instantiate(objects[0], objects[0].transform.position, objects[0].transform.rotation);
            DontDestroyOnLoad(Vase);
        }
        if (val == 1)
        {
            Destroy(Vase);
            Destroy(KuanYu);
            Destroy(Ding);
            Destroy(Altarpiece);
            Polyxena = Instantiate(objects[1], objects[1].transform.position, objects[1].transform.rotation);
            DontDestroyOnLoad(Polyxena);
        }
        if (val == 2)
        {
            Destroy(Vase);
            Destroy(Polyxena);
            Destroy(Ding);
            Destroy(Altarpiece);
            KuanYu = Instantiate(objects[2], objects[2].transform.position, objects[2].transform.rotation);
            DontDestroyOnLoad(KuanYu);
        }
        if (val == 3)
        {
            Destroy(Vase);
            Destroy(Polyxena);
            Destroy(KuanYu);
            Destroy(Altarpiece);
            Ding = Instantiate(objects[3], objects[3].transform.position, objects[3].transform.rotation);
            DontDestroyOnLoad(Ding);
        }
        if (val == 4)
        {
            Destroy(Vase);
            Destroy(Polyxena);
            Destroy(KuanYu);
            Destroy(Ding);
            Altarpiece = Instantiate(objects[4], objects[4].transform.position, objects[4].transform.rotation);
            DontDestroyOnLoad(Altarpiece);
        }
    }
}
