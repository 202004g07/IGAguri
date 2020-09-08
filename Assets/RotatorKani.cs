using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotatorKani : MonoBehaviour
{
    Vector3 kaniPos = new Vector3(0.5f, 6, 20);
    public float Speed = 30;

    private void FixedUpdate()
    {
        transform.RotateAround(kaniPos, Vector3.up, Speed * Time.fixedDeltaTime);
    }

}
