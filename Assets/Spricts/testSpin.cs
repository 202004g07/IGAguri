using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSpin : MonoBehaviour
{
    Vector3 target;
    public float Speed = 30;
    bool isHit = false;

    private void Start()
    {
        target = new Vector3(transform.position.x, 0, transform.position.z);
    }

    private void FixedUpdate()
    {
        Debug.Log(transform.rotation.eulerAngles.x);
        if (transform.rotation.x <= 0.7f && isHit)
        {
            // Spin the object around the world origin at 20 degrees/second.
            transform.RotateAround(target, Vector3.right, Speed * Time.fixedDeltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Tera"))
        {
            isHit = true;
        }
    }

}
