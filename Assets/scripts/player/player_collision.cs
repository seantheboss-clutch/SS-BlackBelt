using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    public GameObject GameManager;
    public GameObject feather;
    public bool player_touch_well;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "feather")
        {
            GameManager.GetComponent<GameManager>().got = true;
            feather.GetComponentInChildren<feather_instantiation>().collected = true;
            
        }
        if (collision.gameObject.tag == "terrain")
        {
            this.GetComponent<player_move>().terrain = true;
        } else
        {
            this.GetComponent<player_move>().terrain = false;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "well")
       {
            other.gameObject.SetActive(false);
            player_touch_well = true;
       }
    }
}
