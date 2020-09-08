using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject BulletPrefab;
    public float Speed = 1000;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(BulletPrefab, MainCam.transform.position, MainCam.transform.rotation);

            bullet.GetComponent<BulletController>().Shoot(Speed);

            Destroy(bullet, 3f);
        }
    }
}
