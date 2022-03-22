using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
   public float speed = 3;

   public GameObject ball;

   private Vector2 ballPos;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {
        ballPos = ball.transform.position;
        if (transform.position.y > ballPos.y) {
            transform.position += new Vector3(0, -speed*Time.deltaTime);
        }

        if (transform.position.y < ballPos.y) {
            transform.position += new Vector3(0, speed*Time.deltaTime);
        }
    }
}
