using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrail : MonoBehaviour
{
    public GameObject trailObject;

    public float spawnTime;
    private float spawnTimer;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(spawnTimer <= 0)
        {
            SpawnTrail();
            spawnTimer = spawnTime;
        }
        else
        {
            spawnTimer -= Time.fixedDeltaTime;
        }
    }

    private void SpawnTrail()
    {
        if (rb.velocity.magnitude == 0) return;

        GameObject part = Instantiate(trailObject, transform.position, Quaternion.identity);
        Destroy(part, 1.5f);
    }
}
