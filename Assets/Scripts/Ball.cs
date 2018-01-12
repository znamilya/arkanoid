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

                GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 10f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // GetComponent<AudioSource>().Play();
    }
}
