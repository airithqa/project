using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyAmmo : MonoBehaviour
{
    private float rangeX = 40.0f;
    private float rangeZ = 40.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > rangeZ || transform.position.z < -rangeZ)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rangeZ || transform.position.x < -rangeZ)
        {
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }
    }
}
