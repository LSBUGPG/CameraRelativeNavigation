using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float distance = 10.0f;
    public float angle = 30.0f;
    public float smooth = 1.0f;
    Vector3 velocity;

    void Update()
    {
        float r = Mathf.Deg2Rad * angle;
        Vector3 back = target.forward * distance * Mathf.Cos(r);
        Vector3 up = target.up * distance * Mathf.Sin(r);
        Vector3 position = target.position - back + up;
        transform.position = Vector3.SmoothDamp(transform.position, position, ref velocity, smooth);
        transform.LookAt(target.position);
    }
}
