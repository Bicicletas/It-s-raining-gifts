using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private int counter;
    private int maxCounter = 20;

    private void Start()
    {
        counter = 0;
    }

    private void OnTriggerEnter(Collider otherTrigger)
    {
        if (otherTrigger.gameObject.CompareTag("Present"))
        {
            counter++;
            Debug.Log($"Llevas {counter} regalos recogidos");
            Destroy(otherTrigger.gameObject);
            if(counter >= maxCounter)
            {
                Debug.Log("Has ganado");
                //Time.timeScale = 0;
            }
        }
        if (otherTrigger.gameObject.CompareTag("Coal"))
        {
            Destroy(gameObject);
            //Time.timeScale
        }
    }
}
