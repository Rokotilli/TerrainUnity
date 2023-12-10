using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;    
    [SerializeField] private int numberOfSpawns = 10;
    [SerializeField] private Terrain terrain;
    [SerializeField] private float ySpawnOffset = 1.0f;
    
    void Start()
    {
        TerrainData terrainData = terrain.terrainData;

        for (int i = 0; i < numberOfSpawns; i++)
        {
            float randX = Random.Range(0f, terrainData.size.x);
            float randZ = Random.Range(0f, terrainData.size.z);

            Vector3 spawnPosition = new Vector3(randX, 0f, randZ);

            float y = terrain.SampleHeight(spawnPosition) + ySpawnOffset;
            spawnPosition.y = y;

            Quaternion spawnRotation = Quaternion.Euler(0f, 0f, 90f);

            coinPrefab = Instantiate(coinPrefab, spawnPosition, spawnRotation);
        }
    }
}