using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //create a camera controller script, where you can look around with WASD and scroll to zoom in and out
    public float speed = 10.0f;
    public float zoomSpeed = 2.0f;
    public float zoomMin = 5.0f;
    public float zoomMax = 15.0f;
    public GameObject buildingUI;
    void Start() {
    }
    void Update()
    {
        //move camera with WASD
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20.0f;
        }
        else
        {
            speed = 10.0f;
        }

        //zoom in and out with scroll
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        pos.y -= scroll * 1000 * zoomSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, zoomMin, zoomMax);
        transform.position = pos;
    }
}
