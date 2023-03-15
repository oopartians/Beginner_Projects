using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isPlayer1;
    public float speed = 5;

    public Rigidbody2D rb;

    private float movement; // Input Value (Vertical)
    private Vector3 startPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    private void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPos;
    }
}
