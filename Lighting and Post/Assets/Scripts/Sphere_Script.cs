using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Script : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    private Rigidbody _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(0, 0, -moveSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(0, 0, moveSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(moveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(-moveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
