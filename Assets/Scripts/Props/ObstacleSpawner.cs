using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject blockPrefab; 
    public Transform player;

    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 2f;

    public float minHeight = -3f;
    public float maxHeight = 3f;
    public float spawnDistance = 10f;
    public float distanceInGroup = 1f;

    private float spawnInterval = 0;

    private int blocksInGroup = 1;
    private int groupCount = 0;

    private void Update()
    {
        if (spawnInterval <= 0)
        {
            SpawnGroup();
            spawnInterval = GetRandomInterval();
        }

        spawnInterval -= Time.deltaTime;
    }

    private void SpawnGroup()
    {
        for(int i = 0; i < blocksInGroup; i++)
        {
            SpawnBlock(spawnDistance + distanceInGroup * i);
        }
        groupCount++;

        if (groupCount / (blocksInGroup + 1) > blocksInGroup)
            blocksInGroup++;
    }

    private void SpawnBlock(float distance)
    {
        float randomHeight = Random.Range(minHeight, maxHeight);

        Vector3 spawnPosition = new Vector3(player.position.x + distance, randomHeight, 0.0f);

        Instantiate(blockPrefab, spawnPosition, Quaternion.identity, transform);
    }

    private float GetRandomInterval()
    {
        float interval = Random.Range(minSpawnInterval, maxSpawnInterval);
        return interval;
    }
}
