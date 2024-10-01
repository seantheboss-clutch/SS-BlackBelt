using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    public GameObject GameManager;
    public Quaternion w_quat = Quaternion.Euler(90f,0f,0f);
    public Vector3 w_rot;
    public GameObject feather;
    public well_assignment wa;
    public bool drink;
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
        if (collision.gameObject.tag == "well")
        { 

            if (collision.gameObject.transform.parent.name != wa.dead_well.name)
            {
               GameManager.GetComponent<GameManager>().player_touched_well = true;
            }
            collision.gameObject.SetActive(false);  
            
        }

    }
}
