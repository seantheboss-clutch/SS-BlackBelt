using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    public GameObject GameManager;
    public GameObject friend;
    public Quaternion w_quat = Quaternion.Euler(90f,0f,0f);
    public Vector3 w_rot;
    public GameObject feather_i;
    public well_assignment wa;
    public bool drink;
    public bool friend_found;
    void Start()
    {
        friend_found = false;
    }
    void Update()
    {
        if(friend_found)
        {
            friend.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 15, this.transform.position.z);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("feather"))
        {
            GameManager.GetComponent<GameManager>().got = true;
            feather_i.GetComponent<feather_instantiation>().collected = true;
            
        }

        if(collision.gameObject.CompareTag("journal"))
        {
            Destroy(collision.gameObject);
            GameManager.GetComponent<GameManager>().revelation = true;
            Destroy(collision.gameObject);
        }
        
        if (collision.gameObject.tag == "terrain")
        {
            this.GetComponent<player_move>().terrain = true;
        } else
        {
            this.GetComponent<player_move>().terrain = false;

        }

        if (collision.gameObject.tag == "well")
        { 

            if (collision.gameObject.transform.parent.name != wa.dead_well.name)
            {
               GameManager.GetComponent<GameManager>().player_touched_well = true;
            }
            //GameObject c = collision.gameObject.GetComponent<well_placeholder>().plane_child;
            //c.SetActive(false);
            collision.gameObject.SetActive(false);
        }
        if(collision.gameObject.tag == "water")
        {
            collision.gameObject.SetActive(false);
        }
        
        if(collision.gameObject.CompareTag("village"))
        {
            GameManager.GetComponent<GameManager>().end_game = true;
            GameManager.GetComponent<GameManager>().destination = true;
        }
        if (collision.gameObject.CompareTag("friend"))
        {
            friend_found = true;
        }
    }
}
