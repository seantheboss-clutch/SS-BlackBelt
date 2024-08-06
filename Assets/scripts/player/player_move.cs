using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public Rigidbody player_rb;
    public int speed;
    public bool terrain;
    public bool climb;
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            player_rb.velocity = transform.TransformDirection(Vector3.forward * speed);
        }
        if (Input.GetKeyDown("s"))
        {
            player_rb.velocity = transform.TransformDirection(Vector3.back * speed);
        }
        if(Input.GetKeyDown("space"))
        {
            if (climb)
            {
                player_rb.velocity = transform.TransformDirection(Vector3.up * speed * 2);
            }
            else
            {
                if (!terrain)
                {
                    player_rb.velocity = transform.TransformDirection(Vector3.up * speed);
                }
            }
        }
    }
}
