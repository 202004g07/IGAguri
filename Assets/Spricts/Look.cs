using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{

    public Transform verRot;
    public Transform horRot;
    public float sence = 1;

    // Use this for initialization
    void Start()
    {
        verRot = transform.parent;
        horRot = GetComponent<Transform>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        verRot.transform.Rotate(0, X_Rotation * sence, 0);
        horRot.transform.Rotate(-Y_Rotation * sence, 0, 0);
    }
}
