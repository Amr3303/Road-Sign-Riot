using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Carcontroller : MonoBehaviour
{
    private float m_horizontalInput;
    private float m_verticalInput;
    private float m_steeringAngle;
    public WheelCollider FrontD;
    public WheelCollider RearD;
    public WheelCollider FrontP;
    public WheelCollider RearP;
    public Transform FrontDT;
    public Transform RearDT;
    public Transform FrontPT;
    public Transform RearPT;
    public float maxSteerAngle = 30;
    public float motorForce = 500;
    public float maxSpeed = 120f; // Maximum speed in km/h
    public Text SpeedText;
    private void Update()
    {
        SpeedText.text = (GetComponent<Rigidbody>().velocity.magnitude * 3.6f).ToString("0") + ("m/h");
        
        

    }
    public float GetSpeed()
    {

        return GetComponent<Rigidbody>().velocity.magnitude * 3.6f;
    }
    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        LimitSpeed();
        UpdateWheelPoses();
    }

    private void GetInput()
    {
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticalInput = Input.GetAxis("Vertical");
    }

    private void Steer()
    {
        m_steeringAngle = maxSteerAngle * m_horizontalInput;
        FrontD.steerAngle = m_steeringAngle;
        FrontP.steerAngle = m_steeringAngle;
    }

    private void Accelerate()
    {
        RearD.motorTorque = m_verticalInput * motorForce;
        RearP.motorTorque = m_verticalInput * motorForce;
    }

    private void LimitSpeed()
    {
        // Convert km/h to m/s
        float speed = GetComponent<Rigidbody>().velocity.magnitude * 3.6f;

        if (speed > maxSpeed)
        {
            // Calculate the new velocity
            Vector3 newVelocity = GetComponent<Rigidbody>().velocity.normalized * (maxSpeed / 3.6f);

            // Apply the new velocity
            GetComponent<Rigidbody>().velocity = newVelocity;
        }
    }

    private void UpdateWheelPoses()
    {
        UpdateWheelPose(FrontD, FrontDT);
        UpdateWheelPose(RearD, RearDT);
        UpdateWheelPose(FrontP, FrontPT);
        UpdateWheelPose(RearP, RearPT);
    }

    private void UpdateWheelPose(WheelCollider _collider, Transform _transform)
    {
        Vector3 _pos = _transform.position;
        Quaternion _quat = _transform.rotation;

        _collider.GetWorldPose(out _pos, out _quat);

        _transform.position = _pos;
        _transform.rotation = _quat;
    }
}

