using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class DelayToDestroy : MonoBehaviour
{
    [SerializeField]
    private float destoryDelay;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(destoryDelay);
    }
}
