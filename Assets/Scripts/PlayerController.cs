using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private float horizontalInput;
    
    void update()
    {
        horizontalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }
}
