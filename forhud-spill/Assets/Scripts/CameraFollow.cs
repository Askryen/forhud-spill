using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;        // Player to follow
    public Vector3 offset;          // Offset from player (e.g. new Vector3(0, 2, -10))
    public float smoothSpeed = 5f;  // Smooth movement

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}