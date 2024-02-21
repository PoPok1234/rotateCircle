using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    protected float speed = 4;

    private int currentDirectionRandomize;
    protected Vector2 currentVector;

    protected void currentDirection()
    {
        currentDirectionRandomize = Random.Range(0, 3);

        switch (currentDirectionRandomize)
        {
            case 0:
                currentVector = Vector2.up;
                break;
            case 1:
                currentVector = Vector2.right;
                break;
            case 2:
                currentVector = Vector2.down;
                break;
            case 3:
                currentVector = Vector2.left;
                break;
        }
    }
}
