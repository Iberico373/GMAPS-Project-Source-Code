using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skybox : InteractivePuzzlePiece<HingeJoint>
{
    public float power = 250f;

    public Rigidbody rigidBody;

    void Awake()
    {
        JointMotor boxMotor = physicsComponent.motor;
        boxMotor.targetVelocity = power;
        physicsComponent.motor = boxMotor;
    }

    protected override void ApplyActiveState()
    {
        rigidBody.isKinematic = false;
        physicsComponent.useMotor = true;
    }

    protected override void ApplyInactiveState()
    {
        rigidBody.isKinematic = true;
        physicsComponent.useMotor = false;
    }
}
