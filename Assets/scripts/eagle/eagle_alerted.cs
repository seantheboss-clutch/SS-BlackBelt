using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_alerted : MonoBehaviour
{
    public Rigidbody eagle_rb;
    public GameObject player;
    public LayerMask layerMask;
    void Update()
    {
        if (Physics.Raycast(this.transform.position, Vector3.down, 1000f, layerMask))
        {
            this.GetComponent<eagle_move>().eagle_not_alerted = false;
        }
    }
}
