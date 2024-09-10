using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wing_casual : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }
    void Awake()
    {
       
    }
    void Update()
    {
        animator.SetTrigger("wing1");
        animator.SetTrigger("wing2");
        //transform.DetachChildren();
        //animator.SetInteger();
    }
}
