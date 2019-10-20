using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnerController : MonoBehaviour
{
    [SerializeField]
    private float spawnDelay;

    [SerializeField]
    private List<EnemySpawner> enemySpawners;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        var waitForSeconds = new WaitForSeconds(spawnDelay);
        for (; ; )
        {
            yield return waitForSeconds;
            var randomSpawnPointIndex = Random.Range(0, enemySpawners.Count);
            var spawnPointSelected = enemySpawners[randomSpawnPointIndex];
            spawnPointSelected.Spawn();
        }
    }
}
