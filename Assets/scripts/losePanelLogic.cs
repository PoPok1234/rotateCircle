using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class losePanelLogic : MonoBehaviour
{
    private int highScore;
    private int score;

    [SerializeField] private Text highScoreText;
    [SerializeField] private Text scoreText;

    private void Awake()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        score = PlayerPrefs.GetInt("score");

        highScoreText.text = $"HighScore: {highScore -= 1}!";
        scoreText.text = $"Score: {score -= 1}";
    }

    public void restartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.SetInt("gameOver", 0);
        Time.timeScale = 1f;
    }

    public void returnMenuButton()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.SetInt("gameOver", 0);
        Time.timeScale = 1f;
    }
}
