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
        Material jacketPanel = new Material(jacketMaterial);
        Material jacketZipper = new Material(jacketPanel);

        float red = Random.Range(0, 255) / 255f;
        float blue = Random.Range(0, 255) / 255f;
        float green = Random.Range(0, 255) / 255f;
        jacketPanel.SetColor("_BaseColor", new Color(red, green, blue));

        float red_rim = Random.Range(0, 255) / 255f;
        float blue_rim = Random.Range(0, 255) / 255f;
        float green_rim = Random.Range(0, 255) / 255f;

        jacketPanel.SetColor("_RimColor", new Color(red_rim, green_rim, blue_rim));
        jacketZipper.SetColor("_BaseColor", new Color(red_rim, green_rim, blue_rim));

        jacketPanel.SetColor("_EmissionColor", Color.black);
        jacketZipper.SetColor("_EmissionColor", Color.black);

        jacketPanel.DisableKeyword("_EMISSION");
        jacketZipper.DisableKeyword("_EMISSION");
        
        List<Material> materials = new() { jacketPanel, jacketPanel, jacketPanel, jacketPanel, jacketZipper, jacketZipper, jacketZipper, jacketZipper } ;
        meshRender.SetMaterials(materials);
    }
}
