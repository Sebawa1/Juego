using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraMovement : MonoBehaviour
{
    public float speed = 5.0f; // Speed of camera movement

    public Vector4 cotas;
    
    public float zoomSpeed = 1f;
    public float minOrthographicSize = 1f;
    public float maxOrthographicSize = 20f;
    
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += movement * speed * Time.deltaTime;

        if (transform.position.x < cotas.x)
        {
            transform.position = new Vector3(cotas.x,transform.position.y,-10);
        }
        if (transform.position.x > cotas.y)
        {
            transform.position = new Vector3(cotas.y,transform.position.y,-10);
        }
        if (transform.position.y < cotas.z)
        {
            transform.position = new Vector3(transform.position.x,cotas.z,-10);
        }
        if (transform.position.y > cotas.w)
        {
            transform.position = new Vector3(transform.position.x,cotas.w,-10);
        }
        
        float mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.orthographicSize -= mouseScroll * zoomSpeed;
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minOrthographicSize, maxOrthographicSize);

    }
}

