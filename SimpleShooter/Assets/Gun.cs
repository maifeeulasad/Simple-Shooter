using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    float modifier = 0.00001f;

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
            transform.Rotate(transform.rotation.eulerAngles + new Vector3(0, 0, 1) * modifier, Space.Self);
        if (Input.GetKeyDown(KeyCode.S))
            transform.Rotate(transform.rotation.eulerAngles - new Vector3(0, 0, 1) * modifier, Space.Self);
    }
}
