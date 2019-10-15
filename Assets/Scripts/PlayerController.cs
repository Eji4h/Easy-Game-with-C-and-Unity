using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float moveAngle;

    // Update is called once per frame
    void Update()
    {
        var oldX = transform.position.x;
        UpdatePosition();
        UpdateRotation(oldX);
    }

    private void UpdatePosition()
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

    private void UpdateRotation(float oldX)
    {
        var deltaXPos = transform.position.x - oldX;
        var targetZAngle = 0f;
        if (Mathf.Abs(deltaXPos) > 0.1f)
            targetZAngle = deltaXPos > 0f ? -moveAngle : moveAngle;

        var targetRotation = Quaternion.AngleAxis(targetZAngle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * speed);
    }
}
