using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private float turnSpeed = 1.0f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        
    }

    private void FixedUpdate(){
        if(Input.GetKey(KeyCode.W)){
            rb.AddForce(this.transform.up * speed);
           
        }
        if(Input.GetKey(KeyCode.A)){
             rb.AddTorque(turnSpeed);
        }
        if(Input.GetKey(KeyCode.D)){
            rb.AddTorque(-turnSpeed);
        }
    }

}
