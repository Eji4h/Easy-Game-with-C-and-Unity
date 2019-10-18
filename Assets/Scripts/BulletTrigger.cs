using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        bool isEnemy = other.tag == "Enemy";
        if (isEnemy)
        {
            var enemyController = other.GetComponent<EnemyController>();
            enemyController.Destroy();
            ScoreController.Instance.IncreaseScore(10);
        }
    }
}
