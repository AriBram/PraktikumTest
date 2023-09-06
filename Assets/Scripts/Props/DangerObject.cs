using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerObject : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Можно было бы использовать TryGetComponent, но это немного сложнее для понимания

        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<PlayerHealth>().GetHit();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHealth>().GetHit();
        }
    }
}
