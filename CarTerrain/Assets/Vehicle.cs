using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float power = 15000f;
    public float verInput, horInput;
    public Wheel[] wheels;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void FixedUpdate()
    {
        ProcessForces();
        //ProcessGravity();
    }

    private void ProcessGravity()
    {
        throw new NotImplementedException();
    }

    private void ProcessForces()
    {
        foreach (Wheel w in wheels)
        {
            w.Accelerate(verInput * power);
            w.UpdatePosition();
        }
    }

    void ProcessInput()
    {
        verInput = Input.GetAxis("Vertical");
        horInput = Input.GetAxis("Vertical");
    }
}
