using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    public ConstantForce constant;
    public Rigidbody rb;
    public GameObject defaultCam;
    public GameObject mazeCam;

    [Range(200f, 500f)]
    public float turnSpeed = 200f;

    void FixedUpdate()
    {
        float zRotation = Input.GetAxis("Horizontal") * -turnSpeed;
        float xRotation = Input.GetAxis("Vertical") * turnSpeed;

        if (zRotation != 0f || xRotation!= 0f)
        {          
            rb.isKinematic = false;
            constant.enabled = true;
            constant.torque = new Vector3(xRotation, 0f, zRotation);
        }

        else
        {
            rb.isKinematic = true;
            constant.enabled = false;
        }
            
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Marble"))
        {
            if (defaultCam.activeSelf == true)
            {
                mazeCam.SetActive(true);
                defaultCam.SetActive(false);                
            }

            else if (defaultCam.activeSelf != true)
            {
                defaultCam.SetActive(true);
                mazeCam.SetActive(false);
            }
        }
    }
}
