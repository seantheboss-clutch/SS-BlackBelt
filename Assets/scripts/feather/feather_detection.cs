using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feather_detection : MonoBehaviour
{
    public GameObject player;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);
        if(player)
        {
            /*if(distance <= 500)
            {
                player.GetComponent<player_move>().dist= "Hot";
            } else if(distance > 500 & distance < 1000)
            {
                player.GetComponent<player_move>().dist= "Warm";
            }
            else
            {
                player.GetComponent<player_move>().dist = "Cold";

            }*/
            player.GetComponent<player_move>().dist = distance.ToString();
        }
    }
}
