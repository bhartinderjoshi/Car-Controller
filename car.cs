using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public WheelCollider Front_Right;
    public WheelCollider Front_Left;   
    public WheelCollider Rear_Right;
    public WheelCollider Rear_Left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SteeringAngle();
    }
    public void MotorTorque(float Input)
    {
        // Front WheelDrive
        Front_Left.motorTorque = Input * 1000;
        Front_Right.motorTorque = Input * 1000;
       
        // Rear WheelDrive
        // Rear_Left.motorTorque = Input * 1000;
        // Rear_Right.motorTorque = Input * 1000;
    }
    public void SteeringAngle()
    {
        float Input = SimpleInput.GetAxis("Horizontal");
        Front_Left.steerAngle = Input * 15;
        Front_Right.steerAngle = Input * 15;
        
    }
    public void Brake(float BrakeValue)
    {
        Front_Left.brakeTorque = BrakeValue;
        Front_Right.brakeTorque = BrakeValue;
    }
}
