using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    public GameObject GameManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "feather")
        {
            GameManager.GetComponent<GameManager>().got = true;
        }
    }
}
