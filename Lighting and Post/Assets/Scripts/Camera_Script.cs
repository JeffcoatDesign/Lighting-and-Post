using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    public float rotateSpeed = 10f;

    void Update()
    {
        Vector3 rotation = Vector3.up* rotateSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(rotation);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-rotation);
        }
    }
}
