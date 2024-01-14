using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArm : MonoBehaviour
{
    [SerializeField]
    bool right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(right) 
        {
            if (Input.GetMouseButton(1))
            {
                transform.eulerAngles += new Vector3(0,-10f,0);
            }
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                transform.eulerAngles += new Vector3(0, 10f, 0);
            }
        }
        
    }
}
