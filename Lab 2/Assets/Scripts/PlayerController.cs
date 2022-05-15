using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed=15.0f;
    
    private float moveVertical;
    private float moveHorizontal;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveVertical = Input.GetAxis("Vertical");
        moveHorizontal = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime*moveVertical);
        
        transform.Rotate(Vector3.up*Time.deltaTime*turnSpeed*moveHorizontal);
    }
}
