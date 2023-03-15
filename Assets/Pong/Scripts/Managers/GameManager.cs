using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Players")] // Just for Inspector
    public PlayerController player1;
    public PlayerController player2;

    [Header("Ball")]
    public Ball ball;

    [Header("Goals")]
    public Goal goalP1;
    public Goal goalP2;

    [Header("Score UI")]
    public TMP_Text textP1;
    public TMP_Text textP2;

    private int scoreP1 = 0;
    private int scoreP2 = 0;

    private void Start()
    {
        // Initialize UI
        textP1.text = scoreP1.ToString();
        textP2.text = scoreP2.ToString();
    }

    // Call by Goal, Who Scored? Add Score and Reset
    public void Scored(bool isPlayer1Goal)
    {
        if(isPlayer1Goal)
        {
            scoreP2++;
            textP2.text = scoreP2.ToString();   // int to string
        }
        else
        {
            scoreP1++;
            textP1.text = scoreP1.ToString();
        }
        ResetRound();
    }

    // Reset GameObjects' Position
    private void ResetRound()
    {
        player1.Reset();
        player2.Reset();
        ball.Reset();   // And Launch!
    }
}
