using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int speed = 10;
    float modifier = 0.00001f;
    public GameObject bullet;
    GameObject spawnPoint;

    void Start()
    {
        spawnPoint = transform.GetChild(0).gameObject;
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletI = Instantiate(bullet, spawnPoint.transform);
            bulletI.GetComponent<Rigidbody>().velocity = bulletI.transform.forward * -speed;
            Destroy(bulletI, 20);
        }
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(transform.rotation.eulerAngles + new Vector3(0, 0, 1) * modifier, Space.Self);
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(transform.rotation.eulerAngles - new Vector3(0, 0, 1) * modifier, Space.Self);
    }
}
