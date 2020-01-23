using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int speed = 10;
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
        if (Input.GetKeyDown(KeyCode.X))
            transform.rotation = new Quaternion(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
    }
}
