using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class RandomJacketColor : MonoBehaviour
{
    public SkinnedMeshRenderer meshRender;
    public Material jacketMaterial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        int red = Random.Range(0, 255);
        int blue = Random.Range(0, 255);
        int green = Random.Range(0, 255);
        jacketMaterial.SetColor("_BaseColor", new Color(red, green, blue));

        int red_rim = Random.Range(0, 255);
        int blue_rim = Random.Range(0, 255);
        int green_rim = Random.Range(0, 255);

        jacketMaterial.SetColor("_RimColor", new Color(red_rim, green_rim, blue_rim));
        
        List<Material> test = new List<Material> { jacketMaterial } ;
        meshRender.SetMaterials(test);
    }
}
