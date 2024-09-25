using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle_alerted : MonoBehaviour
{
    public Rigidbody eagle_rb;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y == player.transform.position.y)
        {
            this.GetComponent<eagle_move>().eagle_not_alerted = false;
            this.GetComponent<eagle_attack>().attack_value = 1;
        }
    }
}
