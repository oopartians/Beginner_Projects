using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

    public Rigidbody2D rb;

    private Vector3 startPos;

    public AudioSource playerBounceSource;
    public AudioSource wallBounceSource;

    private void Start()
    {
        startPos = transform.position;
        Launch();        
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1; // Left or Right
        float y = Random.Range(0, 2) == 0 ? -1 : 1; // Up or Down

        rb.velocity = new Vector2 (x * speed, y * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPos;
        Launch();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.velocity *= new Vector2(1.1f, 1.1f);
            playerBounceSource.Play();
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            wallBounceSource.Play();
        }
    }
}
