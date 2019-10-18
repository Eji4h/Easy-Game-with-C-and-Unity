using System;
using System.Threading.Tasks;
using UnityEngine;

public class DelayToDestroy : MonoBehaviour
{
    [SerializeField]
    private float destoryDelay;

    // Start is called before the first frame update
    async void Start()
    {
        await Task.Delay(TimeSpan.FromSeconds(destoryDelay));
        Destroy(gameObject);
    }
}
