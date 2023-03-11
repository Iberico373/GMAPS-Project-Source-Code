using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 10.0F;

    private GameObject game;

    void Awake()
    {
        game = GetComponent<GameObject>();
    }

    void OnTriggerEnter(Collider other)
    {
        Vector3 explosionPos = transform.position;
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (rb != null)
        {
            if (gameObject.name.Contains("Explosive") == true)
            {
                rb.constraints = RigidbodyConstraints.FreezePositionZ;
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
            }

            else if (gameObject.name.Equals("Launcher"))
            {
                rb.constraints = RigidbodyConstraints.FreezePositionZ;
                rb.AddExplosionForce(power, explosionPos, radius);
            }

            else if (gameObject.name.Contains("LauncherN") == true)
            {
                rb.AddExplosionForce(power, explosionPos, radius);
            }

            else
                rb.constraints = RigidbodyConstraints.None;            
        }
            
    }
}
