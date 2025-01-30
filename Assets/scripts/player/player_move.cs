using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_move : MonoBehaviour
{
    public Rigidbody player_rb;
    public ParticleSystem walking;
    public ParticleSystem backward_walk;
    public int speed;
    public int jumps_allowed_when_powered;
    public bool terrain;
    public bool climb;
    public bool jumped;
    public GameObject game_manager;
    public GameObject store;
    public Text distance_from_feather;
    public bool player_can_move = true;

    void Start()
    {
        jumps_allowed_when_powered = 5;
        distance_from_feather.text = "Cold";
    }
    void Update()
    {
        //distance_from_feather.text = dist;
        if (player_can_move)
        {
            if (Input.GetKey("w"))
            {
                player_rb.velocity = transform.TransformDirection(Vector3.forward * speed);
                walking.Play();
            }
            if (Input.GetKey("s"))
            {
                player_rb.velocity = transform.TransformDirection(Vector3.back * speed);
                backward_walk.Play();
            }
            if (Input.GetKey("space"))
            {
                if (player_rb.velocity.y >= -3 && climb)
                {
                   if (jumps_allowed_when_powered > 0)
                   {
                       jumped = true;
                       if (jumped == true)
                       {
                           player_rb.velocity = transform.TransformDirection(Vector3.up * speed * 15);
                           jumps_allowed_when_powered -= 1;
                           print(jumps_allowed_when_powered);
                           jumped = false;
                       }
                   } else
                   {
                       climb = false;
                       jumps_allowed_when_powered = 5;
                   }                              
                }
            }
        }
        
        if(Input.GetKeyDown("1"))
        {
            setUpOrder(1);
        }
        if (Input.GetKeyDown("2"))
        {
            setUpOrder(2);
        }
        if (Input.GetKeyDown("3"))
        {
            setUpOrder(3);
        }
        void setUpOrder(int a)
        {
            store.GetComponent<store>().price_req = a;
            store.GetComponent<store>().request_pur = true;
        }
    }
}
