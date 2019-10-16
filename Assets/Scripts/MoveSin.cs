using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSin : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float range;

    private float startXPos;

    // Start is called before the first frame update
    void Start()
    {
        startXPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        var x = startXPos + Mathf.Sin(Time.time * speed) * range;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
