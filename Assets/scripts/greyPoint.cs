using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class greyPoint : points
{
    private CounterScore counter;
    private Text scoreText;
    private int highScore;
    private Rigidbody2D rb;


    private void Awake()
    {
        scoreText = FindObjectOfType<Text>();
        currentDirection();
        rb = gameObject.GetComponent<Rigidbody2D>();
        highScore = PlayerPrefs.GetInt("HighScore");
        counter = FindObjectOfType<CounterScore>();
    }

    void Update()
    {
        rb.velocity = currentVector * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            counter.score += 1;
            scoreText.text = $"Score: {PlayerPrefs.GetInt("score")}";
            if (counter.score >= highScore)
            {
                PlayerPrefs.SetInt("HighScore", counter.score);
            }
        }
    }
}
