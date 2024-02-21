using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redPoint : points
{
    private Rigidbody2D rb;
    private int gameOver;

    private void Awake()
    {
        currentDirection();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = currentVector * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Time.timeScale = 0f;
            gameOver = 1;
            PlayerPrefs.SetInt("gameOver", gameOver);
        }
    }
}
