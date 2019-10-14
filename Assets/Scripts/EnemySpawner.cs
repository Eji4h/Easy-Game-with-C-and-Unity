using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enemyPrefabs;

    public void Spawn()
    {
        var randomEnemyIndex = Random.Range(0, enemyPrefabs.Count);
        var enemySelectedPrefab = enemyPrefabs[randomEnemyIndex];
        var bulletPattern = Instantiate(enemySelectedPrefab, transform.position, transform.rotation);
    }
}
