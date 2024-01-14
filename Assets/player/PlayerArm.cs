using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArm : MonoBehaviour
{
    [SerializeField]
    bool right;

    float armSpead=8;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (right)
        {
            if (Input.GetMouseButtonDown(1)&&armSpead>=0)
            {
                StartCoroutine(Rotate(-1));
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0) && armSpead >= 0)
            {
                StartCoroutine(Rotate(1));
            }
        }

    }

    IEnumerator Rotate(int a)
    {
        for (int i = 0; i < 30; i++) 
        {
            transform.eulerAngles += new Vector3(0, a*3, 0);
            yield return new WaitForSeconds(0.13f/30);
        }

    }
}
