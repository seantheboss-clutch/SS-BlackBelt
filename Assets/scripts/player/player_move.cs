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
    public GameObject hanglider;
    public Text distance_from_feather;
    public GameObject canvas_object;
    public bool player_can_move = true;

    void Start()
    {
        hanglider.SetActive(false);
        jumps_allowed_when_powered = 5;
        distance_from_feather.text = "Cold";
        canvas_object.SetActive(true);
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
            else
            {
                player_rb.velocity = transform.TransformDirection(Vector3.forward*0);
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
                        gliding();
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
        if(Input.GetKey("0"))
        {
            canvas_object.SetActive(true);
        }
        if (Input.GetKey("-"))
        {
            canvas_object.SetActive(false);
        }
        void setUpOrder(int a)
        {
            store.GetComponent<store>().price_req = a;
            store.GetComponent<store>().request_pur = true;
        }
        void gliding()
        {
            hanglider.SetActive(true);
            hanglider.transform.position = new Vector3(this.transform.position.x+10,this.transform.position.y+20,this.transform.position.z);
        }
    }
}
