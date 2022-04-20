using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Transform player;

    public float MouseSensitivity = 10;

    private float x = 0;
    private float y = -90;
   

    void Update()
    {
        //input
        x += -Input.GetAxis("Mouse Y") * MouseSensitivity;
        y += Input.GetAxis("Mouse X") * MouseSensitivity;

        //clamping
        x = Mathf.Clamp(x, -90, 90);

        //rotation
        transform.localRotation = Quaternion.Euler(x, 0, 0);
        transform.localRotation = Quaternion.Euler(0, y, 0);
    }
}