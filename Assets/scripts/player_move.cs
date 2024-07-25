using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public Rigidbody player_rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player_rb.transform.TransformDirection(Vector3.right * 10f);
        if (Input.GetKeyDown("left"))
        {
            print("no");
            player_rb.transform.TransformDirection(Vector3.right * 10f);
        }
    }
}
