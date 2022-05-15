using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAmmo : MonoBehaviour
{
    public Transform Car;
    public Rigidbody shoot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody s=Instantiate(shoot,Car.position, Car.rotation);
        }
    }
}
