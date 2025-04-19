using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_alerted : MonoBehaviour
{
    public Rigidbody eagle_rb;
    public GameObject player;
    public LayerMask layerMask;
    public eagle_move e_m;
    void Update()
    {
        
        if (Physics.Raycast(this.transform.position, Vector3.down, 2000f, layerMask) || e_m.rand == 7)
        {
            this.GetComponent<eagle_move>().eagle_not_alerted = false;
            player.GetComponent<player_move>().canvas_object.SetActive(true);
        }
    }
}
