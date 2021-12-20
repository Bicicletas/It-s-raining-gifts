using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLimits : MonoBehaviour
{
    private float xLimR = 7.8f;
    private float xLimL = -7.3f;
    
    void Start()
    {
        if (transform.position.x > xLimR)
        {
            transform.position = new Vector3(xLimR, 
                transform.position.y, transform.position.z);
        }
        if (transform.position.x < xLimL)
        {
            transform.position = new Vector3(xLimL, 
                transform.position.y, transform.position.z);
        }
    }
}
