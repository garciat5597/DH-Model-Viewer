using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatScript : MonoBehaviour
{

    public GameObject obj;

    public Texture2D diffuse;
    public Texture2D specular;
    public Texture2D roughness;
    public Texture2D normalMap;
    public Texture2D weights0123;  
    public Texture2D weights4567;
    public Texture2D weights89AB;
    public GameObject basisFunctions;


    private Renderer objRenderer;
    // Start is called before the first frame update
    void Start()
    {
        objRenderer = obj.GetComponent<Renderer>();
    }

    public void ChangeTexture()
    {
        objRenderer.material.SetTexture("_BaseMap", diffuse);
        objRenderer.material.SetTexture("_SpecGlossMap", specular);
        objRenderer.material.SetTexture("_RoughnessMap", roughness);
        objRenderer.material.SetTexture("_BumpMap", normalMap);
        objRenderer.material.SetTexture("_BasisWeights0123", weights0123);
        objRenderer.material.SetTexture("_BasisWeights4567", weights4567);
        objRenderer.material.SetTexture("_BasisWeights89AB", weights89AB);
    }
}
