using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wing_casual : MonoBehaviour
{
    public Animator animator;
    public bool called_out;
    void Start()
    {
        animator = GetComponent<Animator>();

    }
    void Update()
    {
        animator.SetTrigger("wing2");
        if (called_out)
        {
            animator.SetTrigger("talon");
        }
    }
}
