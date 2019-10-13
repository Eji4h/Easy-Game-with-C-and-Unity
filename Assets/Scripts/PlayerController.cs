using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    void Update()
    {
#if !UNITY_EDITOR && (UNITY_ANDROID || UNITY_IOS)
        if (Input.touchCount == 0)
            return;

        var touch = Input.touches.First();
        var inputPosition = touch.position;
#else 
        if (!Input.GetMouseButton(0))
            return;
        var inputPosition = Input.mousePosition;
#endif
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(inputPosition), out hit))
        {
            var targetPosition = new Vector3(hit.point.x, transform.position.y, transform.position.z);
            var step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
        }
    }
}
