using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    // public GameObject UImanager;
    public void Throw(float Power)
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * Power);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.CompareTag("Monkey"))
        {
            //  UImanager.GetComponent<ScoreCount>().AddScore();
        }
        Destroy(gameObject, 0.3f);
    }

}
