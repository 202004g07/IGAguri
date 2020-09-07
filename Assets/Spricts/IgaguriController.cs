using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Throw(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime);
    }
    public void Throw(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

}
