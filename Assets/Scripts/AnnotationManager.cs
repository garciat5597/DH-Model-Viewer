using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnotationManager : MonoBehaviour
{
    public GameObject AnnotationParent;
    public Transform[] annotations;
    // Start is called before the first frame update
    void Start()
    {
        if (!AnnotationParent)
        {
            AnnotationParent = GameObject.FindGameObjectWithTag("AnnotationParent");
            if (AnnotationParent)
            {
                annotations = AnnotationParent.GetComponentsInChildren<Transform>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!AnnotationParent)
        {
            AnnotationParent = GameObject.FindGameObjectWithTag("AnnotationParent");
            if (AnnotationParent)
            {
                annotations = AnnotationParent.GetComponentsInChildren<Transform>();
            }
        }
    }

    public void ToggleAnnotations()
    {
        if (AnnotationParent)
        {
            foreach (Transform annotation in annotations)
            {
                if (annotation.gameObject.activeSelf == true)
                {
                    annotation.gameObject.SetActive(false);
                }
                else
                {
                    annotation.gameObject.SetActive(true);
                }
            }
        }

    }
}
