using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_move : MonoBehaviour
{
    public Rigidbody player_rb;
    public int speed;
    public bool terrain;
    public bool climb;
    public GameObject game_manager;
    public GameObject store;
    public string dist = "";
    public Text distance_from_feather;
    public bool player_can_move = true;
    void Update()
    {
        //distance_from_feather.text = dist;
        if (player_can_move)
        {
            if (Input.GetKey("w"))
            {
                player_rb.velocity = transform.TransformDirection(Vector3.forward * speed);
            }
            if (Input.GetKey("s"))
            {
                player_rb.velocity = transform.TransformDirection(Vector3.back * speed);
            }
            if (Input.GetKey("space"))
            {
                if (player_rb.velocity.y >= -3)
                {
                    if (climb)
                    {
                        player_rb.velocity = transform.TransformDirection(Vector3.up * speed*15);
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
