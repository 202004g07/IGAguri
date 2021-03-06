﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenerator : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject igaguriPrefab;
    public float ThrowPower = 2000;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Vector3 worldDir = ray.direction;


            Instantiate(igaguriPrefab, MainCam.transform.position, MainCam.transform.rotation).GetComponent<IgaguriController>().Throw(ThrowPower);
        }
    }
}
