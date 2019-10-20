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
        var waitForSeconds = new WaitForSeconds(shootDelay);
        for (; ; )
        {
            yield return waitForSeconds;
            Instantiate(bulletPatternPrefab, transform.position, Quaternion.identity);
        }
    }
}
