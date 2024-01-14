using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 0.1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * 0.1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * 0.1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * 0.1f;
        }

    }
}
