using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject defaultCam;
    public GameObject skyBoxCam;

    void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Marble"))
        {
            if (defaultCam.activeSelf == true)
            {
                skyBoxCam.SetActive(true);
                defaultCam.SetActive(false);
            }

            else if (defaultCam.activeSelf != true)
            {
                defaultCam.SetActive(true);
                skyBoxCam.SetActive(false);
            }
        }
    }
}
