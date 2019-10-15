using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnerController : MonoBehaviour
{
    [SerializeField]
    private float spawnDelay;

    [SerializeField]
    private List<EnemySpawner> enemySpawners;

    // Start is called before the first frame update
    void Start()
    {
        SpawnInterval(spawnDelay, enemySpawners);
    }

    async void SpawnInterval(float spawnDelay, List<EnemySpawner> enemySpawners)
    {
        for (; ; )
        {
            await Task.Delay(TimeSpan.FromSeconds(spawnDelay));

            var randomSpawnPointIndex = Random.Range(0, enemySpawners.Count);
            var spawnPointSelected = enemySpawners[randomSpawnPointIndex];
            spawnPointSelected.Spawn();
        }
    }
}
