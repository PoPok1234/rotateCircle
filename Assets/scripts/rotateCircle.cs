using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCircle : MonoBehaviour
{
    private float angular = -0.4f;

    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject pause;

    void Update()
    {
        gameObject.transform.Rotate(0, 0, angular);

        if (Input.GetMouseButtonDown(0))
        {
            angular *= -1;
        }

        if(PlayerPrefs.GetInt("gameOver") == 1)
        {
            losePanel.SetActive(true);
            pause.SetActive(false);
        }
    }
}
