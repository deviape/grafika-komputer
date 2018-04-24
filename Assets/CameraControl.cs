using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float minimumX = -60f;
    public float maximumX = 60f;
    public float minimumY = -360f;
    public float maximumY = 360f;

    public float sensifityX = 15f;
    public float sensifityY = 15f;

    public Camera cam;

    float rotationX = 0f;
    float rotationY = 0f;

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensifityY;
        rotationX += Input.GetAxis("Mouse Y") * sensifityX;

        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);

        transform.localEulerAngles = new Vector3(0, rotationY, 0);
        cam.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
