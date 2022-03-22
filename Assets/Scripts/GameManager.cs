using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  public GameObject ball;

  public GameObject player1;
  public GameObject player1Goal;

  public GameObject player2;
  public GameObject player2Goal;

  public Text player1Text;
  public Text player2Text;

  private int player1Score;
  private int player2Score;

  public bool AIGame;

    public void player1Scored() {
        player1Score++;
        player1Text.text = player1Score.ToString();
        ResetPosition();
    }

     public void player2Scored() {
        player2Score++;
        player2Text.text = player2Score.ToString();
        ResetPosition();
    }

    

    private void ResetPosition() {
        // ball.GetComponent<Ball>().Reset();
        // player1.GetComponent<Players>().Reset();
        // player2.GetComponent<Players>().Reset();

        if (AIGame) {
             ball.GetComponent<Ball>().Reset();
             player2.GetComponent<Players>().Reset();
        } else {
             ball.GetComponent<Ball>().Reset();
             player1.GetComponent<Players>().Reset();
             player2.GetComponent<Players>().Reset();
        }

    }















}
