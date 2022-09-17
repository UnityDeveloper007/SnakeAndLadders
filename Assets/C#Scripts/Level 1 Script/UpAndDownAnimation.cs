using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDownAnimation : MonoBehaviour
{
    public float amp;
    public float freq;
    //public GameObject init;
    Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.localPosition;               
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(initPos.x, Mathf.Sin(Time.time * freq) * amp + initPos.y+30, 0);
    }
}