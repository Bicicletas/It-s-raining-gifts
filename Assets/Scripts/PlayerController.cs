using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    public float horizontalInput;

    private SpawnManager spawnManager;

    private void Start()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        //Vector3 aimBot = new Vector3(spawnManager.spawnPos.x, transform.position.y, transform.position.z);
        transform.Translate(Vector3.right * spawnManager.spawnPos.x * speed * Time.deltaTime);
    }

}
