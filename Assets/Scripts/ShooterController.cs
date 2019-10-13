using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    [SerializeField]
    private float shootDelay;

    [SerializeField]
    private GameObject bulletPatternPrefab;

    // Start is called before the first frame update
    void Start()
    {
        ShootInterval(shootDelay);
    }

    async void ShootInterval(float shootDelay)
    {
        for (; ; )
        {
            await Task.Delay(TimeSpan.FromSeconds(shootDelay));
            var bulletPattern = Instantiate(bulletPatternPrefab, transform.position, Quaternion.identity);
        }
    }
}
