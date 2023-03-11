using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    private FixedJoint fixedJoint;

    void Awake()
    {
        fixedJoint = GetComponent<FixedJoint>();    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Jetpack") == true)
        {
            FixedJoint fixedJoint = other.GetComponent<FixedJoint>();

            fixedJoint.breakForce = 1f;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Marble"))
        {
            fixedJoint.breakForce = 1f;
        }
    }
}
