using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    //Player
    bool onStartButton;//ボタンにマウスが乗ってるか
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
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);//1光線の飛ばし方計算
            if (Physics.Raycast(ray,out RaycastHit hitInfo))//2光線飛ばす   ray hitInfoタグがButton
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
                if (Physics.Raycast(ray, out RaycastHit hitInfo))//ray hitInfoタグがButton
                {
                    if (hitInfo.collider.CompareTag("StartButton"))
                    {
                        Debug.Log("S押す");
                        onStartButton = false;
                    }
                    else if (hitInfo.collider.CompareTag("CsButton"))
                    {
                        Debug.Log("C押す");
                        onCsButton = false;
                    }
                }
                
            }
            
        }
        if (onStartButton)
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo) && hitInfo.collider.CompareTag("StartButton"))//ray hitInfoタグがButton
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
            if (Physics.Raycast(ray, out RaycastHit hitInfo) && hitInfo.collider.CompareTag("CsButton"))//ray hitInfoタグがButton
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
