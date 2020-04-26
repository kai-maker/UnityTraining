using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    [Range(-10, 10)]
    public float x, y, z;
    void Start()
    {
        var pos = transform.position;
        x = pos.x;
        y = pos.y;
        z = pos.z;
    }
    
    void Update()
    {
        var pos = transform.position;
        pos.x = x;
        pos.y = y;
        pos.z = z;
        transform.position = pos;
    }
}
