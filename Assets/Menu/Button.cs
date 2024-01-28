using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    //Player
    bool onStartButton;//�{�^���Ƀ}�E�X������Ă邩
    bool onCsButton;
    [SerializeField]
    Transform startTransform;
    [SerializeField]
    Transform csTransform;
    [SerializeField]
    Camera camera; 
    
    void Start()
    {
        startTransform.localScale = new Vector3(0.15f, 0.4f, 1f);
        csTransform.localScale = new Vector3(0.15f, 0.4f, 1f);
        onStartButton = false;
        onCsButton = false;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);//1�����̔�΂����v�Z
            if (Physics.Raycast(ray,out RaycastHit hitInfo))//2������΂�   ray hitInfo�^�O��Button
            {
                if (hitInfo.collider.CompareTag("StartButton"))
                {
                    onStartButton = true;
                }
                else if (hitInfo.collider.CompareTag("CsButton"))
                {
                    onCsButton = true;
                }
                
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (onStartButton)
            {
                Ray ray = camera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit hitInfo))//ray hitInfo�^�O��Button
                {
                    if (hitInfo.collider.CompareTag("StartButton"))
                    {
                        Debug.Log("S����");
                        onStartButton = false;
                    }
                    else if (hitInfo.collider.CompareTag("CsButton"))
                    {
                        Debug.Log("C����");
                        onCsButton = false;
                    }
                }
                
            }
            
        }
        if (onStartButton)
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo) && hitInfo.collider.CompareTag("StartButton"))//ray hitInfo�^�O��Button
            {
                startTransform.localScale = new Vector3(0.15f, 0.15f, 1f);
            }
            else
            {
                startTransform.localScale = new Vector3(0.18f, 0.4f, 1f);
            }
        }
        else
        {
            startTransform.localScale = new Vector3(0.18f, 0.18f, 1f);
        }

        if (onCsButton)
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo) && hitInfo.collider.CompareTag("CsButton"))//ray hitInfo�^�O��Button
            {
                csTransform.localScale = new Vector3(0.15f, 0.15f, 1f);
            }
            else
            {
                csTransform.localScale = new Vector3(0.18f, 0.18f, 1f);
            }
        }
        else
        {
            csTransform.localScale = new Vector3(0.18f, 0.18f, 1f);
        }
    }
}
