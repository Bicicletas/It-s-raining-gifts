using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    private float randomSpeed;
    private float minSpeed = 10f;
    private float maxSpeed = 20f;
    
    private float randomLimit = 2f;
    private Vector3 randomRotationAxis;
    
    
    void Start()
    {
        randomSpeed = Random.Range(minSpeed, maxSpeed);
        randomRotationAxis = new Vector3(Random.Range(-randomLimit, randomLimit),
            Random.Range(-randomLimit, randomLimit),
            Random.Range(-randomLimit, randomLimit));
    }
    
    void Update()
    {
        transform.Rotate(randomRotationAxis, randomSpeed * Time.deltaTime);
    }
}
