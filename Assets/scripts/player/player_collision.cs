using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    public GameObject GameManager;

    private void OnTriggerEnter(Collider other)
    {
        print("terra");
        if(other.gameObject.tag == "feather")
        {
            GameManager.GetComponent<GameManager>().got = true;
        }
        if(other.gameObject.tag == "terrain")
        {
            print("terra nova");
            this.GetComponent<player_move>().terrain = true;
        }
    }
}
