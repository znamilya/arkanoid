using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Paddle paddle;
    private Vector3 paddleToBall;
    private bool isMoving;

    void Start()
    {
        paddle = FindObjectOfType<Paddle>();
        paddleToBall = transform.position - paddle.transform.position;
    }

    void Update()
    {
        if (!isMoving)
        {
            transform.position = paddle.transform.position + paddleToBall;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                isMoving = true;
                Rigidbody2D rb = GetComponent<Rigidbody2D>();

                rb.velocity = new Vector2(5f, 10f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //isMoving = false;
    }
}
