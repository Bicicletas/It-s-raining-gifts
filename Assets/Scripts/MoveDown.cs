using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float speed = 2f;
    private float minLimY = -1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

        if (transform.position.z < minLimY)
        {
            Time.timeScale = 0;
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }
    }
    
    
}
