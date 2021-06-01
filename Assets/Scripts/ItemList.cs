using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemList : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] GameObject sphere;
    public Button button;

    public void AddCube()
    {
        sphere.SetActive(false);
        cube.SetActive(true);
    }

    public void AddSphere()
    {
        cube.SetActive(false);
        sphere.SetActive(true);
    }
}
