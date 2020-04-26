using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        var hol = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");
        var vel =  _rb.velocity;
        vel.x = hol;
        vel.y = ver;
        _rb.velocity = vel * 5f;
    }
}
