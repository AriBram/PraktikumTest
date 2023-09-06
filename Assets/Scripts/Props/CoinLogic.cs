using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLogic : MonoBehaviour
{
    float speed = 3f;
    Transform target;

    private void FixedUpdate()
    {
        if (target)
            MoveToTarget();
    }

    private void MoveToTarget()
    {
        Vector2 translation = (target.position - transform.position) * speed * Time.fixedDeltaTime;
        
        transform.Translate(translation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            target = collision.transform;
        }
            
    }
}
