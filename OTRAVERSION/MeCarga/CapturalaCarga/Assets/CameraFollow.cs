using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraFollow : MonoBehaviour
{
    public Transform target; // The object the camera will follow
    public Vector3 offset = new Vector3(0f, 0f, -10f); // Offset distance between the camera and the target
    public bool followObject = false; // Condition to start following the object

    void LateUpdate()
    {
        if (followObject && target != null)
        {
            transform.position = target.position + offset;
        }
    }
}