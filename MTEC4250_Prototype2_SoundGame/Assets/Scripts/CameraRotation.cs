using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float CamX;
    public float CamY;

    public Transform orientation;

    float Xrotation;
    float Yrotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //****** Mouse input ******

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * CamX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * CamY;

        Yrotation += mouseX;
        Xrotation -= mouseY;
        Xrotation = Mathf.Clamp(Xrotation, -90f, 90f);

        //****** Mouse input ******

        //****** Camera rotation & orientation ******

        transform.rotation = Quaternion.Euler(Xrotation, Yrotation, 0);
        orientation.rotation = Quaternion.Euler(0, Yrotation, 0);

        //****** Camera rotation & orientation ******
    }
}
