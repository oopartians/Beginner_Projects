using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    public AudioSource goalSource;

    public GameManager gm;

    // Trigger == Scored!
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            gm.Scored(isPlayer1Goal);
            goalSource.Play();
        }
    }
}
