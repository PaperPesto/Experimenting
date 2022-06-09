using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public WheelCollider wcol;
    public Transform wmesh;
    // Start is called before the first frame update
    void Start()
    {
        wcol = GetComponent<WheelCollider>();
        wmesh = transform.Find("mesh_wheel");
    }

    public void Accelerate(float powerinput)
    {
        wcol.motorTorque = powerinput;
    }

    public void Decelerate(float breakinput)
    {
        wcol.brakeTorque = breakinput;
    }

    public void UpdatePosition()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;

        wcol.GetWorldPose(out pos, out rot);
        wmesh.transform.position = pos;
        wmesh.transform.rotation = rot;
    }
}
