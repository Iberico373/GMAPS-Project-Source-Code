using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public Rigidbody marble;

    void OnTriggerEnter(Collider other)
    {
       if (other.name.Equals("Marble"))
        {
            if (marble.useGravity != true)
            {
                marble.useGravity = true;
            }            
        }
    }
}
