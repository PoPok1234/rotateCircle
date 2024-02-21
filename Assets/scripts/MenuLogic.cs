using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
    [SerializeField] private GameObject howToPlayPanel;
    [SerializeField] private GameObject exitPanel;

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OnApplicationQuit() { }

    public void howToPlay()
    {
        howToPlayPanel.SetActive(true);
        exitPanel.SetActive(true);
    }

}
