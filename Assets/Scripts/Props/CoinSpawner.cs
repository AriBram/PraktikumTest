using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    public Transform player;

    public float spawnInterval = 1f;
    public float maxSpawnInterval = 2f;

    public float minHeight = -2f;
    public float maxHeight = 2f;
    public float spawnDistance = 20f;

    private float spawnTimer;

    private void Start()
    {
        spawnTimer = spawnInterval;
    }

    private void Update()
    {

        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            Spawn();
            spawnTimer = spawnInterval;
        }
    }

    private void Spawn()
    {
        float randomHeight = Random.Range(minHeight, maxHeight);

        Vector3 spawnPosition = new Vector3(player.position.x + spawnDistance, randomHeight, 0f);

        Instantiate(coin, spawnPosition, Quaternion.identity);
    }
}
