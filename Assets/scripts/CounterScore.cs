using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterScore : MonoBehaviour
{
    public int score { get; set; }

    private void Awake()
    {
        score += 1;
    }
    void Update()
    {
        PlayerPrefs.SetInt("score", score);
    }
}
