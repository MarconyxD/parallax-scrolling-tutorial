using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
    }
}
