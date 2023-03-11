using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : InteractivePuzzlePiece<ConstantForce>
{
    public float power = 50f;
    public FixedJoint fixedJoint;

    void Awake()
    {
        physicsComponent.force = new Vector3(0f, power, power / 20f);
    }

    void OnTriggerEnter(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();

        if (fixedJoint.connectedBody == null)
        {
            fixedJoint.connectedBody = rb;
        }
    }

    protected override void ApplyActiveState()
    {
        physicsComponent.enabled = true;
    }

    protected override void ApplyInactiveState()
    {
        physicsComponent.enabled = false;
    }
}
