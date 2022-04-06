using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

  public int maxScore = 3;

  public void CheckVictory()
  {
      if (player1Score == maxScore) {
          SceneManager.LoadScene("Victory2");
      }
      if (player2Score == maxScore) {
          SceneManager.LoadScene("Victory1");
      }
  }

    public void player1Scored() {
        player1Score++;
        CheckVictory();
        player1Text.text = player1Score.ToString();
        ResetPosition();
    }

     public void player2Scored() {
        player2Score++;
        CheckVictory();
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
