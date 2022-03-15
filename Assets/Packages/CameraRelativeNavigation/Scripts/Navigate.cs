using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigate : MonoBehaviour
{
    new public Transform camera;
    public float speed = 1.0f;
    public float smooth = 1.0f;
    Vector3 movement;
    Vector3 velocity;
    Vector3 direction;
    float spin;

    public void RelativeMovement(Vector3 movement)
    {
        if (movement.sqrMagnitude < 1.0f)
        {
            direction = Vector3.Cross(camera.right, Vector3.up);
        }
        Quaternion bearing = Quaternion.LookRotation(direction, Vector3.up);
        this.movement = (bearing * movement) * speed;
    }

    private void Update()
    {
        if (movement.sqrMagnitude > 0.0f)
        {
            Quaternion look = Quaternion.LookRotation(movement, Vector3.up);
            float angle = Quaternion.Angle(transform.rotation, look);
            transform.rotation = Quaternion.Slerp(transform.rotation, look, Mathf.SmoothDamp(0.0f, 1.0f, ref spin, smooth));
            Vector3 target = transform.position + movement;
            transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, smooth);
        }
    }
}
