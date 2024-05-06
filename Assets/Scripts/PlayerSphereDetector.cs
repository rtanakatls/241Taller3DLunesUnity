using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSphereDetector : MonoBehaviour
{
    private bool isDecting;
    private GameObject detectedObject;

    private void Update()
    {
        if (isDecting)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (detectedObject != null)
                {
                    Destroy(detectedObject);
                    detectedObject = null;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SphereDetector"))
        {
            isDecting = true;
            detectedObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("SphereDetector"))
        {
            isDecting = false;
            detectedObject = null;
        }
    }

}