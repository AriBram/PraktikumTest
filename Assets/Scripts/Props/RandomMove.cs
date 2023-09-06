using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public float changeTime = 1.5f;

    float changeTimer;
    bool isMoveUp;

    void Start()
    {
        isMoveUp = Random.Range(0, 2) == 0;
        changeTimer = changeTime + Random.Range(0.2f, 0.5f);
    }

    void Update()
    {
        CheckTime();
        MoveVertical();
    }

    private void CheckTime()
    {
        if(changeTimer <= 0)
        {
            isMoveUp = !isMoveUp;
            changeTimer = changeTime;
        }
        else
        {
            changeTimer -= Time.deltaTime;
        }
    }

    private void MoveVertical()
    {
        if (isMoveUp)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
    }
}
