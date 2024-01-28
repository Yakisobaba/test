using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    //Player
    [SerializeField]
    Camera camera;
    GameObject hitObject;
    
    void Start()
    {
    }

    
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray,out hitInfo))//2������΂�   ray hitInfo�^�O��Button
            {
                hitObject = hitInfo;
                if (hitInfo.collider.CompareTag("Button"))
                {
                    hitInfo.collider.gameObject.GetComponent<Button>().TransformButton(true);
                }
                
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
                if (Physics.Raycast(ray, out hitInfo)&& hitInfo.collider.gameObject.GetComponent<Button>().onButton)//ray hitInfo�^�O��Button
                {
                    if (hitInfo.collider.CompareTag("Button"))
                    {
                        hitInfo.collider.gameObject.GetComponent<Button>().OnClick();
                    }
                    hitInfo.collider.gameObject.GetComponent<Button>().TransformButton(false);
                }
        }



            
        if (!(Physics.Raycast(ray, out hitInfo) && hitInfo.collider.CompareTag("Button") && hitInfo.collider.gameObject.GetComponent<Button>().onButton))//ray hitInfo�^�O��Button
        {
            hitInfo.collider.gameObject.GetComponent<Button>().TransformButton(false);
        }
        
    }
}
