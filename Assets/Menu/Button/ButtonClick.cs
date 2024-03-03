using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    //Player
    [SerializeField]
    Camera mCamera;
    GameObject hitObject = null;

    void Start()
    {
    }


    void Update()
    {
        Ray ray = mCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        Debug.Log("!");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Down");
            if (Physics.Raycast(ray, out hitInfo))//2光線飛ばす  
            {
                hitObject = hitInfo.collider.gameObject;
                Debug.Log(hitObject);
                if (hitInfo.collider.gameObject.CompareTag("Button"))
                {
                    hitInfo.collider.gameObject.GetComponent<Button>().TransformButton(true);
                }

            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (Physics.Raycast(ray, out hitInfo)
                && hitInfo.collider.gameObject.TryGetComponent<Button>(out Button button)//TryGetComponent<T>(out T) outに入る　bool返す
                && button.onButton)
            {

                if (hitInfo.collider.gameObject.CompareTag("Button"))
                {
                    button.OnClick();
                }
                button.TransformButton(false);
                hitObject = null;
            }
        }


        if (!(Physics.Raycast(ray, out hitInfo) 
            && hitInfo.collider.gameObject.CompareTag("Button") 
            && hitInfo.collider.gameObject.GetComponent<Button>().onButton)
            )
        {
            if (!(hitObject is null)
                && hitObject.TryGetComponent<Button>(out Button button))
            {
                button.TransformButton(false);
                hitObject = null;
            }

        }

    }
}
