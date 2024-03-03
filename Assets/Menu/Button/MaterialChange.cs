using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using UnityEngine;

public class MaterialChange : Button
{
    //テクスチャ色→default 
    // Start is called before the first frame update
    [SerializeField]
    GameObject partObject;
    Material material;
    Material paMaterial;
    int skinNumber = 0;
    Color[] colors = {
        Color.white,
        Color.blue,
        Color.red,
        Color.magenta,
        Color.yellow,
        Color.cyan,
        Color.gray,
        Color.green,
        Color.black
        };
    enum Part
    {
        Head,
        RHand,
        LHand
    }
    [SerializeField]
    Part part;


    void Start()
    {
        material = GetComponent<Renderer>().material;
        paMaterial = partObject.GetComponent<Renderer>().material;
        switch (part) {
            case Part.Head:
                material.color = colors[PlayerSet.headColors];
                paMaterial.color = colors[PlayerSet.headColors];
                break;
            case Part.RHand:
                material.color = colors[PlayerSet.rHandColors];
                paMaterial.color = colors[PlayerSet.rHandColors];
                break;
            case Part.LHand:
                material.color = colors[PlayerSet.lHandColors];
                paMaterial.color = colors[PlayerSet.lHandColors];
                break;
        }
        
    }

    // Update is called once per frame
    public override void OnClick()
    {
        Debug.Log(skinNumber);
        if (PlayerSet.useColors > (skinNumber + 1) % 9)
        {
            skinNumber = (skinNumber + 1) % 9;
            Debug.Log(skinNumber + "a");
            material.color = colors[skinNumber];
            paMaterial.color = colors[skinNumber];
            if (part == Part.Head) { PlayerSet.headColors = skinNumber; }
            else if (part == Part.LHand) { PlayerSet.lHandColors = skinNumber; }
            else if (part == Part.RHand) { PlayerSet.rHandColors = skinNumber; }
        }
        else
        {
            skinNumber = 0;
            material.color = colors[skinNumber];
            paMaterial.color = colors[skinNumber];
        }
    }
}
