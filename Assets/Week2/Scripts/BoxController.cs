using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    float speed = 5.0f;

    public Rigidbody rb;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(0, Input.GetAxisRaw("Vertical"));
        rb.velocity = movement * speed;
    }
}
