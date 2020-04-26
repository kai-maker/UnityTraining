using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByRigidBody : MonoBehaviour
{
    [Range(-2, 2)]
    public float vx, vy, vz;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        var vel = _rb.velocity;
        vel.x = vx;
        vel.y = vy;
        vel.z = vz;
        _rb.velocity = vel;
    }
}
