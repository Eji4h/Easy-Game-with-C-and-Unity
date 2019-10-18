using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private GameObject explodeParticle;

    public void Destroy()
    {
        Instantiate(explodeParticle, transform.position, Random.rotation);
        GameObject.Destroy(gameObject);
    }
}
