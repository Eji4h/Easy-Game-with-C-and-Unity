using System;
using System.Collections;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    [SerializeField]
    private float shootDelay;

    [SerializeField]
    private GameObject bulletPatternPrefab;

    // Start is called before the first frame update

    IEnumerator Start()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(shootDelay);
            Instantiate(bulletPatternPrefab, transform.position, Quaternion.identity);
        }
    }
}
