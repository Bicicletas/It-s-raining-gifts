using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private int counter;

    private void Start()
    {
        counter = 0;
    }

    private void OnTriggerEnter(Collider otherTrigger)
    {
        if (otherTrigger.gameObject.CompareTag("Present"))
        {
            counter--;
            Debug.Log($"Llevas {counter} regalos recogidos");
            Destroy(gameObject);
        }
    }
}
