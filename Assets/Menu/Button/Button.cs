using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    public bool onButton = false;
    virtual public void OnClick()
    {
        
    }
    public void TransformButton(bool value)
    {
        onButton = value;
    }
    private void Update()
    {
        if (onButton) 
        {
           this.transform.localScale = new Vector3(0.15f, 0.37f, 1f);
        }
        else
        {
            this.transform.localScale = new Vector3(0.18f, 0.4f, 1f);
        }
    }
}
