using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool player1Goal;
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (player1Goal) {
                gameManager.GetComponent<GameManager>().player1Scored();
            }

            else {
                 gameManager.GetComponent<GameManager>().player2Scored();
            }
        }
    }





}
