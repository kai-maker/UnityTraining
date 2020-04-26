using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D;

public class CollisionOrTrigger : MonoBehaviour
{
    private Material _mat;
    private void Start()
    {
        _mat = gameObject.GetComponent<Renderer>().material;
        _mat.color = Color.gray;
    }

    private IEnumerator OnCollisionEnter(Collision other)
    {
        _mat.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        _mat.color = Color.gray;
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        _mat.color = Color.blue;
        yield return new WaitForSeconds(0.5f);
        _mat.color = Color.gray;
    }
}
