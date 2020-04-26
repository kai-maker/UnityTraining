using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimationManager : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Start_Trigger");
        }
    }
}
