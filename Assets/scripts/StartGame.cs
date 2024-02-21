using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject circlePlayer;
    [SerializeField] private GameObject pointsSpawn;
    [SerializeField] private GameObject returnMenuBtn;
    [SerializeField] private GameObject pauseBtn;

    public void PlayGame()
    {
        gameObject.SetActive(false);
        circlePlayer.SetActive(true);
        pointsSpawn.SetActive(true);
        returnMenuBtn.SetActive(false);
        pauseBtn.SetActive(true);
    }

    public void PauseGame()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            circlePlayer.SetActive(true);
        }
        else
        {
            Time.timeScale = 0;
            circlePlayer.SetActive(false);
        }
    }
}
