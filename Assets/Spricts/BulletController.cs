using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class BulletController : MonoBehaviour
{
    public void Shoot(float Power)
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * Power);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }


}
