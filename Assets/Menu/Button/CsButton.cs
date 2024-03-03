using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CsButton : Button
{
    [SerializeField]
    CinemachineBlendListCamera csListCamera;
    [SerializeField]
    CinemachineBlendListCamera startListCamera;
    public void Start()
    {
        csListCamera.enabled = false;
        startListCamera.enabled = true;
    }
    public override void OnClick()
    {
        csListCamera.enabled = true;
        startListCamera.enabled = false;
    }
}
