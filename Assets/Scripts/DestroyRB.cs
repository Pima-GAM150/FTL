using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRB : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
        }
    }
}
