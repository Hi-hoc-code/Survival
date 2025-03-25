using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomEnemy1 : MonoBehaviour
{
    public GameObject radomePrefab;
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = -5f;
    public float maxY = 5f;

    public float spawnInterval = 4f;
    private float timer = 0f;
    private float thirtySecondTimer = 0f; // Thêm timer 30 giây
    private int numberOfObjectsToSpawn = 1; // Số lượng object cần spawn mỗi lần

    void Update()
    {
        timer += Time.deltaTime;
        thirtySecondTimer += Time.deltaTime;

        if (thirtySecondTimer >= 60f)
        {
            numberOfObjectsToSpawn++; // Tăng số lượng object cần spawn
            thirtySecondTimer = 0f; // Reset timer 30 giây
        }

        if (timer >= spawnInterval)
        {
            for (int i = 0; i < numberOfObjectsToSpawn; i++)
            {
                SpawnRadome();
            }
            timer = 0f;
        }
    }

    void SpawnRadome()
    {
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Instantiate(radomePrefab, randomPosition, Quaternion.identity);
    }
}
